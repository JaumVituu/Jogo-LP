using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textMod : MonoBehaviour
{
    string x;
    public Text myText;
 
    // Start is called before the first frame update
    public void Start()
    {
        myText.Text = "pontuação: ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
