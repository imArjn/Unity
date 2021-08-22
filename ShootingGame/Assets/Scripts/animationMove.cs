using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    float defaultMoveSpeed;
    public float rotationSpeed = 270.0f;
    

    public Animator anim;

    public GameObject mainCam;
    public GameObject zoomCam;
    public GameObject gun;

    // Start is called before the first frame update
    void Start()
    {
        defaultMoveSpeed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //for backing up
        if (Input.GetKeyDown(KeyCode.S))
        {
            moveSpeed = 1f;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            moveSpeed = defaultMoveSpeed;
        }


        //for Sprinting
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = 8f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = defaultMoveSpeed;
        }


        transform.Translate(new Vector3(0, 0, verticalInput) * moveSpeed * Time.deltaTime);
        //transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, horizontalInput, 0) * rotationSpeed * Time.deltaTime); 


        //for Walking
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("Walk", true);
            gun.SetActive(false);

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("Walk", false);
        }



        //for Jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetInteger("Jumpp", 1);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetInteger("Jumpp", 0);
        }


        //for running
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.SetInteger("Run", 1);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anim.SetInteger("Run", 0);
        }

        //for WalkingBack
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetInteger("WalkBack", 1);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetInteger("WalkBack", 0);
        }

        //for shooting and ZoomingCamera
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetInteger("Shooting", 1);
            zoomCam.SetActive(true);
            mainCam.SetActive(false);
            gun.SetActive(true);
        }
        if (Input.GetButtonUp("Fire1"))
        {
            anim.SetInteger("Shooting", 0);
            zoomCam.SetActive(true);
            mainCam.SetActive(false);
            gun.SetActive(true);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            anim.SetInteger("ShootingPos", 1);
            zoomCam.SetActive(true);
            mainCam.SetActive(false);
            gun.SetActive(true);
        }
        if (Input.GetButtonUp("Fire2"))
        {
            anim.SetInteger("ShootingPos", 0);
            zoomCam.SetActive(false);
            mainCam.SetActive(true);
            gun.SetActive(true);
        }

        



    }
}
