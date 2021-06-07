using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestWall : MonoBehaviour
{
    public int destroy;
    public GameObject txtCommand;

    void Start()
    {
        destroy = 0;
    }

    
    void Update()
    {
        destroy = txtCommand.GetComponent<lvlText>().onLever;
        if (destroy == 1)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(gameObject);
            }
        }
    }
}
