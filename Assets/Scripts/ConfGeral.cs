using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfGeral : MonoBehaviour
{
    public GameObject menu;
    static public bool pausado;
    // Start is called before the first frame update
    void Start()
    {
        Menu();        
        Pausado(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausado(!pausado);
        }
    }

    public void Pausado(bool statusPause)
    {
        pausado = statusPause;
        menu.SetActive(pausado);
    }

    public void Menu()
    {
        menu = Instantiate(menu, menu.transform.position, menu.transform.rotation) as GameObject;
    }

}
