using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winTxt : MonoBehaviour
{
    public int youWin;
    public GameObject win;
    public UnityEngine.UI.Text winText;

    void Start()
    {
        winText = GetComponent<UnityEngine.UI.Text>();
        youWin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        youWin = win.GetComponent<Character>().uWin;
        if (youWin == 1)
        {
            winText.text = "Parabéns, você ganhou!";
        }
        else
        {
            winText.text = "";
        }
    }
}
