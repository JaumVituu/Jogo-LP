using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCube : MonoBehaviour
{
    public Vector3 p;
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(p);
    }
}
