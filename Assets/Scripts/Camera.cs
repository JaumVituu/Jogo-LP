using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    bool isRightButtonDown;
    bool isLeftButtonDown;
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void Start()
    {
        isLeftButtonDown = false;
        isRightButtonDown = false;
    }

    void Update()
    {
        isLeftButtonDown = Input.GetMouseButtonDown(0);
        isRightButtonDown = Input.GetMouseButtonDown(1);
        if (isLeftButtonDown && offset.x <= 27)
        {
            offset.x += 1;
            isLeftButtonDown = false;
        }
        if (offset.x >= 9)
            if (isRightButtonDown)
            {
                offset.x -= 1;
                isRightButtonDown = false;
            }
    }


    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}