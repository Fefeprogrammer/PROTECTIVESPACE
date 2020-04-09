using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo3 : MonoBehaviour
{
    public int vida = 5;
    

    private Bullet bullet;

    //public List<Transform> tiro;

    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Bullet>();

    }

    // Update is called once per frame

    void Update()
    {
        
        transform.Translate(new Vector3(0, 10 * Time.deltaTime, 0));
        ControleVida();
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
            Debug.Log("O inimigo perder vida");
            
        }
    }

    void ControleVida()
    {
        if(vida == 0)
        {
            Destroy(this.gameObject); 
            Debug.Log("Inimigo derrotado");
        }
    }   
   
    }

   

