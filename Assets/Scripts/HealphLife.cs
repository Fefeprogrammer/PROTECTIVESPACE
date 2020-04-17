using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthLife : MonoBehaviour
{
    public Image vida;
    public float vidaMax = 50.0f;
    public GameObject player;
    public float vidaAtual;

    // Start is called before the first frame update
    void Start()
    {

        vidaAtual = vidaMax;
        //vidaAtual = vidaMax;    


    }

    // Update is called once per frame
    void Update()
    {

        if (vidaAtual >= vidaMax)
        {
            vidaAtual = vidaMax;
        }


        vida.rectTransform.sizeDelta = new Vector2(vidaAtual / vidaMax * 1162, 40);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Bullet")
        {
            vidaAtual -= 1;
        }

        if (other.transform.tag == "ShootBoss")
        {
            vidaAtual -= 1;
        }
    }


}
