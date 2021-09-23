using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public int destroy;
    public GameObject txtCommand;
    public bool isDestroyed;

    void Start()
    {
        destroy = 0;
        isDestroyed = false;
    }

    
    void Update()
    {
        destroy = txtCommand.GetComponent<lvlText>().onLever;
        if (destroy == 1)
        {
            if (Input.GetKey(KeyCode.E))
            {
                isDestroyed = true;
                Destroy(gameObject);               
            }
        }
    }
}
