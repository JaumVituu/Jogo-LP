using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChadCoin : MonoBehaviour
{
    public GameObject points;
    public Vector3 rotation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation);
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
