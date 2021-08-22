using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera360 : MonoBehaviour
{
    public Transform target;
    private Vector3 lookOffset = new Vector3(0,1, 0);
    private float distance =4;
    private float cameraSpeed = 15;

    void Start()
    { }

 void Update()
    {
        Vector3 lookPosition = target.position + lookOffset;
        transform.LookAt(lookPosition);

        if (Vector3.Distance(transform.position, lookPosition) > distance)
        {
            transform.Translate(0, 0, cameraSpeed * Time.deltaTime);
        }


    }
}
