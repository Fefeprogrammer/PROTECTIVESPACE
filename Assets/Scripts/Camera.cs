using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera : MonoBehaviour
{
    public float velocidadeCamera;
   // public Transform target;
    public float tempo = 1f;
    // Start is called before the first frame update
   IEnumerator Start()
    {
        yield return new WaitForSeconds(0);
    }

    // Update is called once per frame
    void Update()
    {
        //move a camera
        velocidadeCamera = (tempo * 0.1f ) * Time.deltaTime ;


        if (tempo < 1)
        {
            tempo = tempo + 0.4f * Time.deltaTime;
        }
        
       
        transform.Translate(0, velocidadeCamera, 0);
        
    }
}
