using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animCamera : MonoBehaviour
{
    public Transform target;
    private Vector3 lookOffset = new Vector3(0, 2, 0);
    private float distance = 3;
    private float cameraSpeed = 3;
    float defaultCameraSpeed;
    
    public float mouseSpeed = 5f;

    void Start()
    {
        defaultCameraSpeed = cameraSpeed;
    }

    void Update()
    {
        //for Sprinting
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            cameraSpeed = 8;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            cameraSpeed = defaultCameraSpeed;
        }

        Vector3 lookPosition = target.position + lookOffset;
        transform.LookAt(lookPosition);

        if (Vector3.Distance(transform.position, lookPosition) > distance)
        {
            transform.Translate(0, 0, cameraSpeed * Time.deltaTime);
        }

       








    }

    
}

