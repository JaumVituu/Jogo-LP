using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlText : MonoBehaviour
{
    public UnityEngine.UI.Text lvText;
    public GameObject player;
    public int onLever;
    public int ePressed;
    public GameObject lever;
    
    void Start()
    {
        lvText = GetComponent<UnityEngine.UI.Text>();
        
        ePressed = 0;
        onLever = 0;
    }

    void Update()
    {
        onLever = player.GetComponent<Character>().tglLever;
        if (onLever == 1)
        {
            lvText.text = "Press E to use the Lever";
            if(Input.GetKey(KeyCode.E))
            {
                ePressed = 1;
                Destroy(gameObject); 
            }
        }
       
        else
        {
            lvText.text = "";
        }
    }
}
