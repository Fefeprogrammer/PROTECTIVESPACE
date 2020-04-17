using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    public float tempo = 0.5f;
    // Start is called before the first frame update


    void Start()
    {
        Destroy(this.gameObject, tempo);
    }

    void Update()
    {
        
    }


    /*public void DestroyExplosionObject()
    {
        Destroy(gameObject, 1.5f);
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }*/
}
