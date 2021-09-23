using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadGame : MonoBehaviour
{
    public void Carregar()
    {
        SceneManager.LoadScene("Cena1");
    }

    public void Sair()
    {
        Application.Quit();
        Debug.Log("Saiu");
    }

    public void CarregarTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void CarregarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
