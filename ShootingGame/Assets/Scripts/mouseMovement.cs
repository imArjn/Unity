using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMovement : MonoBehaviour
{
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        x += Input.GetAxis("Mouse X");
        y += Input.GetAxis("Mouse Y");


        
         transform.rotation = Quaternion.Euler(0, x, 0); 
       //transform.rotation = Quaternion.Euler(-y, x, 0);

    }
}
