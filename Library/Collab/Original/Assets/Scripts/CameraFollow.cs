using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    //public float speed = 0.15f;
    //private Transform target;

    public GameObject objeto;
    //public GameObject vida;
    Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {
        //target = GameObject.FindGameObjectWithTag("Player").transform;

        mainCam = GetComponent<Camera>();

        mainCam.transform.position = new Vector3(objeto.transform.position.x, objeto.transform.position.y, -10);
        //mainCam.transform.position = new Vector3(vida.transform.position.x, vida.transform.position.y, -10);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, speed) + new Vector3(0,0,target.position.y);
            
        }*/
        mainCam.transform.position = new Vector3(objeto.transform.position.x, objeto.transform.position.y, -10);
        //mainCam.transform.position = new Vector3(vida.transform.position.x, vida.transform.position.y, -10);
    }
}


