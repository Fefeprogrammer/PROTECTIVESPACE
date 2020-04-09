using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mina : MonoBehaviour
{

    Rigidbody inimigo;
    public GameObject player;
    Vector2 locPlayer;
    public float velocidade = 1;
    float tempo = 11f;
    bool colid;
    
    public int vida = 2;

    // Start is called before the first frame update
    void Start()
    {
        inimigo = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Seguir();
        CacaPlayer();
        ControleVida();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Bullet")
        {
            vida -= 1;
            Debug.Log("A mina perdeu vida");
        }
    }

    void ControleVida()
    {
        if(vida == 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Mina destruida");
        }
    }

    void Seguir()
    {
        if(colid == true)
        {
            inimigo.transform.position = Vector2.MoveTowards(transform.position, locPlayer, velocidade * Time.deltaTime);
        }
    }

    void CacaPlayer()
    {
        locPlayer = new Vector2(player.transform.position.x, player.transform.position.y);
    }
}
