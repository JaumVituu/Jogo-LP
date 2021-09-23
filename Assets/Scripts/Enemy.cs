using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Vector3 speed;

    public float time;

    public Vector3 PlayerScale;

    public GameObject Player;

    
    void Start()
    {
        
    }
    
    void Update()
    {
        
        PlayerScale = Player.GetComponent<Character>().escala;
        time += Time.deltaTime;
        if (time < 5f)
        {
            speed.z = 0.009f;
            Movement(speed);
        }
        if (time >= 5f && time <= 10)
        {
            speed.z = -0.009f;
            Movement(speed);
        }
        if(time > 10)
        {
            time = 0f;
        }
    }

    void Movement(Vector3 speed)
    {
        transform.Translate(speed);
    }


    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            if (gameObject.tag == "Orange")
            {
                if (transform.localScale.y >= PlayerScale.y)
                {
                    Destroy(gameObject);
                    Debug.Log("Destruiu");
                }

                else
                {
                    SceneManager.LoadScene("GameOver");
                }
            }

            if (gameObject.tag == "Cyan"){
                if (transform.localScale.y <= PlayerScale.y)
                {
                    Destroy(gameObject);
                    Debug.Log("Destruiu");
                }

                else
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
        }
        

    }
}
