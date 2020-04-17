using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{

    /*
     *      PROGRAMADOR: FELIPE DE ARAUJO BUENO
     * */
    public int vida = 75;
    static public bool morto;
    private BulletBoss bullet;
    Player player;
    
    public GameObject exposao;
    private ConfGeral conf;
    public GameObject win;

    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<BulletBoss>();
        vida = 75;
        player = GetComponent<Player>();
        morto = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ConfGeral.pausado)
        {
            return;
        }
        SpawnTiro();
        ControleVida();
        Vencer();
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
            Debug.Log(vida);
           
            
        }
    }

    

    void ControleVida()
    {
        if (vida <= 0)
        {
            Debug.Log("Boss derrotado");
            Instantiate(exposao, transform.position, transform.rotation);
            GetComponent<AudioSource>().Play();
            Vencer();
            //Destroy(this.gameObject);
            //Restart();
            gameObject.SetActive(false);
            morto = true;
            

        }
    }

    public void Vencer()
    {


        if (gameObject.activeInHierarchy == false)
        {
            Instantiate(win, transform.position, transform.rotation);
            Debug.Log("deu certo");
        }


    }



    private void Restart()
    {
       
            UnityEngine.SceneManagement.SceneManager.LoadScene("FaseEstelar");
        
        
    }
}
