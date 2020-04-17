using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    public GameObject win;
    public GameObject bos;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(bos.activeInHierarchy == false)
        {
            Instantiate(win, transform.position, transform.rotation);
            Debug.Log("deu certo");
        }
    }
}
