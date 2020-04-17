using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGame1 : MonoBehaviour
{
    public float tempo = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, tempo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
