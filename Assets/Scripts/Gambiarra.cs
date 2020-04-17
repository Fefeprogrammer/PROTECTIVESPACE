using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gambiarra : MonoBehaviour
{
    CameraFollow camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<CameraFollow>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "MainCamera")
        {
            camera.Movimento(0f);
        }
    }*/
}
