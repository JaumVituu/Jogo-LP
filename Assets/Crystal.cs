using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public Vector3 rotateChange;
    public int gravityOff;
    public int triggerOff;
    public GameObject gravityTrigger;
    public GameObject triggerTrigger;
    public int isGone;



    // Start is called before the first frame update
    void Start()
    {
        gravityOff = 0;
        triggerOff = 0;
        isGone = 0;
    }

    // Update is called once per frame
    void Update()
    {
        isGone = triggerTrigger.GetComponent<Character>().uWin;
        if (gravityOff == 1)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
        else
        {
            gravityOff = gravityTrigger.GetComponent<lvlText>().ePressed;
            transform.Rotate(rotateChange, Space.World);
        }
        if (triggerOff == 1)
        {
            GetComponent<BoxCollider>().isTrigger = true;
            GetComponent<Rigidbody>().useGravity = false;
        }
        else
        {
            triggerOff = triggerTrigger.GetComponent<Character>().crystalIs;
        }
        if (isGone == 1)
        {
            Destroy(gameObject);
            Application.Quit();
        }
    }
}
