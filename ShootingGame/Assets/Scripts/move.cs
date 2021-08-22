using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float rotationSpeed = 270.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0,verticalInput) * moveSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, horizontalInput, 0) * rotationSpeed * Time.deltaTime);

        /*bool jumpd = Input.GetButtonDown("Jump");
        bool jumpu = Input.GetButtonUp("Jump");

        if (jumpd)
        {
            transform.Translate(new Vector3(0,0.1f,0));
        }
        if (jumpu)
        {
            transform.Translate(new Vector3(0,0.2f, 0));
        }*/
    }
}
