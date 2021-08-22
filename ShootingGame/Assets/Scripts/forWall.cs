using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class forWall : MonoBehaviour
{
    //int count = 100;
    //public Text Health;
    //public GameObject GameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("bullet"))
        {
            
            Destroy(collision.gameObject);
            //count -= 20;
            //Health.text = "Enemy Health : " + count.ToString();

            //if (count <= 0)
            //{
                Destroy(gameObject);
            //}
        }

        //if (count <=0)
        //{
           // GameOver.SetActive(true);
        //}
    }
}
