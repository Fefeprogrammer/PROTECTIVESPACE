using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{

    [SerializeField]
    private float power = 800.0f;

    [SerializeField]
    private Transform gun;

    

    [SerializeField]
    private GameObject Shell;

    public float shootintRate = 10f;
    private float shootCooldown;
    Inimigo3 inimigo;
    Player player;

   

    // Start is called before the first frame update
    void Start()
    {
       
        shootCooldown = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ConfGeral.pausado)
        {
            return;
        }

        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
           
            Destroy(this.gameObject);
            Debug.Log("encostou no player");
        }
    }



    public void CmdSpawnShell()
    {
        if(shootCooldown <= 0)
        {
            shootCooldown = shootintRate;

            GameObject instance = Instantiate(Shell, gun.position, gun.rotation) as GameObject;
           

            instance.GetComponent<Rigidbody>().AddForce(gun.forward * power);
           
        }
    }
}

