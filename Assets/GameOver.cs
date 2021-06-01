using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true)
        {
            Application.Quit();
        }
    }
    
    void OnTriggerEnter(Collider end)
    {
        if (end.tag == "Player")
        {
            Debug.Log("Caiu do mundo, fim de jogo");
            gameOver = true;
        }
    }
}
