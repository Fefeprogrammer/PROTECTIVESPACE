using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int vida = 3;

    private Bullet bullet;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Bullet>();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTiro();
    }

    private void SpawnTiro()
    {
        if (bullet != null)
        {
            bullet.CmdSpawnShell();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Bullet")
        {
            vida -= 1;
            Debug.Log("O boss perdeu vida");
        }
    }

    void ControleVida()
    {
        if (vida == 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Boss derrotado");
        }
    }
}
