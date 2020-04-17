using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mina : MonoBehaviour
{

    public Transform target;
    public float speed = 3f;
    public GameObject explosao;

    public int vida = 2;
    

    // Start is called before the first frame update
    void Start()
    {
       
        target = GameObject.FindGameObjectWithTag("Player").transform;

      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * 1.5f * Time.deltaTime);

        if (target.gameObject != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            Instantiate(explosao, transform.position, transform.rotation);
            Destroy(this.gameObject, 3);
        }

        if(other.transform.tag == "Shoot")
        {
            vida -= 1;
            Debug.Log("mina perdeu vida");
            
        }  
    }
    public void ControleVida()
    {
        if(vida <= 0)
        {
            Instantiate(explosao, transform.position, transform.rotation);
            Destroy(this.gameObject, 3);
        }
    }
}

   
