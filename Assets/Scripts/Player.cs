using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

   
    private int vida = 10;

    public float velocidade;
    private BulletPlayer bullet;

    // Start is called before the first frame update
    

    void Start()
    {

       bullet = GetComponent<BulletPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();
        ControleVida();
        SpawnTiro();
       
    }

    private void SpawnTiro()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            if (bullet != null)
            {
                bullet.CmdSpawnShell();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "BulletEnemy")
        {
            vida -= 1;
            Debug.Log("Voce perdeu uma vida");
            
        }

        if(other.transform.tag == "ShootBoss")
        {
            vida -= 4;
            Debug.Log("voce colidiu com boss");
        }

        if(other.transform.tag == "mina")
        {
            vida -= 1;
            Debug.Log("Voce colidiu com a mina");
        }
    }

    void ControleVida()
    {
        if(vida == 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Player destruido");
            /*Invoke("ReloadLevel", 3f);
            Debug.Log("Jogo reiniciado");*/
        }
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Movimentacao()
    {
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector2.left* velocidade * Time.deltaTime);
        }

        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
        }

        if(Input.GetAxisRaw("Vertical") > 0)
        {
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);
        }

        if(Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(Vector2.down * velocidade * Time.deltaTime);
        }
    }
}
