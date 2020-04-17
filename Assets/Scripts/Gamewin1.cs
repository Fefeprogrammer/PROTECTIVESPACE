using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamewin1 : MonoBehaviour
{
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        GetComponent<AudioSource>().Play();
        UnityEngine.SceneManagement.SceneManager.LoadScene("FaseEstelar");
    }

    public void Sair()
    {
        GetComponent<AudioSource>().Play();
        Application.Quit();
    }
}
