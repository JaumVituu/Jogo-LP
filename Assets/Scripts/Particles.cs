using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particulas : MonoBehaviour
{
    public bool message;
    public GameObject player;
    float time;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        message = player.GetComponent<Character>().particles;
        if (message == true)
        {
            ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
            em.enabled = true;
            time += Time.deltaTime;
            if (time >= 5)
            {
                em.enabled = false;
            }
        }
    }
}
