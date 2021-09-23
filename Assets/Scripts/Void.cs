using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Void : MonoBehaviour
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
            SceneManager.LoadScene("GameOver");
            gameOver = false;
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
