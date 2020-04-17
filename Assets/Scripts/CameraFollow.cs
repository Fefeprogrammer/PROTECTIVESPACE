using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float damptime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    public float Tempo;
    
    //public Transform barreira;
    //private GameObject posicao;

    // Start is called before the first frame update
    void Start()
    {
        //barreira = GameObject.FindGameObjectWithTag("Barreira").transform;
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Barreira")
        {
            Debug.Log("Voce colidiu com a barreira");
            Tempo = 0;

        }
    }

    void Update()
    {
        if (ConfGeral.pausado)
        {
            return;
        }


        //transform.Translate(new Vector3(0, Tempo * Time.deltaTime, 0));

       

        transform.Translate(new Vector3(0, Tempo * Time.deltaTime, 0));


        /*if (target)
        {
            Vector3 point = GetComponent<Camera>().WorldToViewportPoint(target.position);
            Vector3 delta = target.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
            Vector3 destination = transform.position + delta;
            transform.positioif(ohn = Vector3.SmoothDamp(transform.position, destination, ref velocity, damptime);
        }*/
    }
    



}
