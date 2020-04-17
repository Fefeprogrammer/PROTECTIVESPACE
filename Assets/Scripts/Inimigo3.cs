using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo3 : MonoBehaviour
{
    public int vida = 5;

    Collider colid;
    private Bullet bullet;
    public float distancia;
    public GameObject explosao;
    
    

    //public List<Transform> tiro;

    // Start is called before the first frame update
    void Start()
    {
        
        bullet = GetComponent<Bullet>();

    }

    // Update is called once per frame

    void Update()
    {
        if (ConfGeral.pausado)
        {
            return;
        }
        //transform.Translate(new Vector3(0, -10 * Time.deltaTime, 0));
        transform.Translate(Vector2.up * 2.5f * Time.deltaTime);
       
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
        if(other.transform.tag == "Shoot")
        {
            vida -= 1;
            Debug.Log("O inimigo perdeu vida");
        }

        /*if(other.transform.tag == "MainCamera")
        { 
            Debug.Log("inimigo colidiu com a camera");
        }
        */
        if(other.transform.tag == "Player")
        {
            Debug.Log("colidiu");
            Instantiate(explosao, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }

    void ControleVida()
    {
        if(vida <= 0)
        {
            Debug.Log("Inimigo derrotado");
            Instantiate(explosao, transform.position, transform.rotation);
            GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
        }
    }   
   
    }

   

