using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class foeBullet : MonoBehaviour
{
    int speed = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Debug.Log("bullet shooted");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("walls"))
        {
            gameObject.SetActive(false);
            
            
        }
    }

}
