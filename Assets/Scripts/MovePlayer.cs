using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    
    public float Tempo = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ConfGeral.pausado)
        {
            return;
        }

        transform.Translate(new Vector3(0, Tempo * Time.deltaTime, 0));
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Bar1")
        {
            Tempo = 0;
        }
    }
}
