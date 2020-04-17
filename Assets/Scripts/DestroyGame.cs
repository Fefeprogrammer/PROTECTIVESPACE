using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGame : MonoBehaviour
{
    public int tempo = 10;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, tempo);
    }

    private void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Boss")
        {
            Destroy(this.gameObject);
        }

        if(other.transform.tag == "inimigo")
        {
            Destroy(this.gameObject);
        }

        if(other.transform.tag == "mina")
        {
            Destroy(this.gameObject);
        }
    }


}
