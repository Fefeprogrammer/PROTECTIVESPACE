using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBoss : MonoBehaviour
{
    public float power = 2000.00f;
    public Transform gun1;
    public Transform gun2;
    public GameObject Prefab;

    public float shootintRate = 0.80f;
    private float shootCooldown;
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

            GameObject instance = Instantiate(Prefab, gun1.position, gun1.rotation) as GameObject;
            GameObject instance1 = Instantiate(Prefab, gun2.position, gun2.rotation) as GameObject;

            instance.GetComponent<Rigidbody>().AddForce(gun1.forward * power);
            instance1.GetComponent<Rigidbody>().AddForce(gun2.forward * power);
        }
    }
}
