using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{

    
    public float power = 800.0f;
    public Transform gun;
    public Transform gun2;
    //public Transform fireEsp;
    public GameObject Shell;
    //public GameObject Firein;

    public float shootintRate = 10f;
    private float shootCooldown;
    Inimigo3 inimigo;
    Boss boss;


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
        if (shootCooldown <= 0)
        {
            shootCooldown = shootintRate;



            GameObject instance = Instantiate(Shell, gun.position, gun.rotation) as GameObject;
            GameObject instance1 = Instantiate(Shell, gun2.position, gun2.rotation) as GameObject;
            //GameObject instance2 = Instantiate(Firein, fireEsp.position, fireEsp.rotation) as GameObject;

            
            instance.GetComponent<Rigidbody>().AddForce(gun.forward * power);
            instance1.GetComponent<Rigidbody>().AddForce(gun2.forward * power);
            //instance2.GetComponent<Rigidbody>().AddForce(fireEsp.forward * power);
        }
    }
}
