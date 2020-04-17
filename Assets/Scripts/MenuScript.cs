using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void Iniciar()
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
