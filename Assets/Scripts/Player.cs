using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    /*
     *  PROGRAMADOR: FELIPE DE ARAUJO BUENO
     * 
     * */
   
    public int vida = 52;
    public GameObject explosao;
    public float velocidade;
    private BulletPlayer bullet;
    public GameObject venceu;
    private Boss boss;
    public Image life;
    public float vidaMax = 90.0f;
    
    public float vidaAtual;

    // Start is called before the first frame update


    void Start()
    {
        vida = 52;
        bullet = GetComponent<BulletPlayer>();
        boss = GetComponent<Boss>();
        vidaAtual = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        if (ConfGeral.pausado)
        {
            return;
        }
        Movimentacao();
        ControleVida();
        SpawnTiro();
        //Vencer();

        if (vidaAtual >= vidaMax)
        {
            vidaAtual = vidaMax;
        }


        life.rectTransform.sizeDelta = new Vector2(vidaAtual / vidaMax * 1162, 40);


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
        if(other.transform.tag == "Bullet")
        {
            vida -= 1;
            Debug.Log(vida);
            vidaAtual -= 1;
            
        }

        if(other.transform.tag == "ShootBoss")
        {
            vida -= 3;
            Debug.Log(vida);
            vidaAtual -= 3;
            
        }

        if(other.transform.tag == "mina")
        {
            vida -= 1;
            Debug.Log("Voce colidiu com a mina");
            vidaAtual -= 1;
        }

        if(other.transform.tag == "inimigo")
        {
            vida -= 5;
            Debug.Log(vida);
            vidaAtual -= 5;
        }
    }

    void ControleVida()
    {
        if(vida <= 0)
        {
            Instantiate(explosao, transform.position, transform.rotation);
            GetComponent<AudioSource>().Play();
            Destroy(this.gameObject, 20);
            Restart();
        }
    }

    private void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("FaseEstelar");
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
