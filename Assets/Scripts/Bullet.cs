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
    private Transform gun1;

    [SerializeField]
    private GameObject Shell;

    public float shootintRate = 10f;
    private float shootCooldown;
    Inimigo3 inimigo;
    public int tempoDestruicao;
   

    // Start is called before the first frame update
    void Start()
    {
       
        shootCooldown = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }
    }

    



    public void CmdSpawnShell()
    {
        if(shootCooldown <= 0)
        {
            shootCooldown = shootintRate;

            GameObject instance = Instantiate(Shell, gun.position, gun.rotation) as GameObject;
            GameObject instance1 = Instantiate(Shell, gun1.position, gun1.rotation) as GameObject;

            instance.GetComponent<Rigidbody>().AddForce(gun.forward * power);
            instance1.GetComponent<Rigidbody>().AddForce(gun1.forward * power);
        }
    }
}

