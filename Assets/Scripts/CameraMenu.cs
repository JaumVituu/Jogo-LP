using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMenu : MonoBehaviour
{
    public Vector3 p;

    void Start(){
        p.x = 0f;
        p.y = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        p.x += Input.GetAxis("Mouse X")/2;
        p.y -= Input.GetAxis("Mouse Y")/2;
        transform.eulerAngles = new Vector3(p.y, p.x, 0);
    }

}
