using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PointsUI : MonoBehaviour
{
    string x;
    public UnityEngine.UI.Text myText;
    public GameObject jogador;
    public int pontos;
 
    // Start is called before the first frame update
    public void Start()
    {
        pontos = 0;
        myText = GetComponent<UnityEngine.UI.Text>();
        myText.text = "pontuação: " + pontos;
    }

    // Update is called once per frame
    void Update()
    {
        pontos = jogador.GetComponent<Character>().score;
        myText.text = "pontuação: " + pontos;
    }
}
