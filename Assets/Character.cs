using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    bool isRightButtonDown;
    bool isLeftButtonDown;
    public int score;
    Vector3 m;
    Vector3 limit;
    

    // Start is called before the first frame update
    void Start()
    {
        var limit = new Vector3(1, 1, 1);
        isLeftButtonDown = false;
        isRightButtonDown = false;
        m.x = 0.0f;
        m.y = 0.0f;
        m.z = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            m.z = 0.05f;
            Movimento(m);
            m.z = 0.0f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            m.z = -0.05f;
            Movimento(m);
            m.z = 0.0f;
        }
        isLeftButtonDown = Input.GetMouseButtonDown(0);
        isRightButtonDown = Input.GetMouseButtonDown(1);
        if (isLeftButtonDown)
        {
            m.y = 0.5f;
            m.x = 0.5f;
            m.z = 0.5f;
            transform.localScale += m;
            isLeftButtonDown = false;
            m.y = 0f;
            m.x = 0f;
            m.z = 0f;
        }
        if (transform.localScale == limit)
        {
        }
        else { 
        if (isRightButtonDown)
        {
            m.y = -0.5f;
            m.x = -0.5f;
            m.z = -0.5f;
            transform.localScale += m;
            isRightButtonDown = false;
            m.y = 0f;
            m.x = 0f;
            m.z = 0f;
        }
    }
    }
    void Movimento(Vector3 m)
    {
        transform.Translate(m);

    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Coin")
        {
            score += 1;
            Debug.Log("Pegou " + score + " moeda");

        }
    }
}


