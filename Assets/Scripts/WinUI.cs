using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinUI : MonoBehaviour
{
    public int youWin;
    public GameObject Character;
    public UnityEngine.UI.Text winText;
    public float tempo;
    public GameObject crystal;
    public string level;

    void Start()
    {
        winText = GetComponent<UnityEngine.UI.Text>();
        youWin = 0;
        tempo = 0f;
        level = crystal.tag;
    }

    // Update is called once per frame
    void Update()
    {
        
        youWin = Character.GetComponent<Character>().uWin;
        if (youWin == 1)
        {
            
            winText.text = "Parabéns, você ganhou!";
            tempo += Time.deltaTime;
            if (level == "Crystal")
            {
                tempo += Time.deltaTime;
                if (tempo >= 5)
                {
                    SceneManager.LoadScene("Cena2");
                }
            }
            if (level == "Crystal2")
            {
                tempo += Time.deltaTime;
                if (tempo >= 5)
                {
                    SceneManager.LoadScene("Menu");
                }
            }
        }
        else
        {
            winText.text = "";
        }
    }
}
