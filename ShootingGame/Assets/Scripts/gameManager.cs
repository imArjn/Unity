using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public static gameManager SharedInstance;
    public List<GameObject> pooledBullets;
    public GameObject bullet;
    public int ammo = 5;
    private int bulletSpeed = 300;


    public Transform end;
    GameObject obj2;

    void Awake()
    {
        SharedInstance = this;
    }

    
    
    // Start is called before the first frame update
    void Start()
    {
        pooledBullets = new List<GameObject>();
        for (int i = 0; i < ammo;i++)
        {
            obj2 = Instantiate(bullet);
            obj2.SetActive(false);
            pooledBullets.Add(obj2);
        }
    }

    public GameObject GetPooledBullet()
    {
        
        GameObject a;
        for (int i = 0; i < ammo; i++)
        {
            if (!pooledBullets[i].activeInHierarchy)
            {
                pooledBullets[i].SetActive(true);
                a = pooledBullets[i];
                return a;
            }
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject CloneBullet = gameManager.SharedInstance.GetPooledBullet();
            
            Rigidbody temp;
            if (CloneBullet != null)
            {
                CloneBullet.transform.position = end.transform.position;
                CloneBullet.transform.rotation = end.transform.rotation;
                temp = CloneBullet.GetComponent<Rigidbody>();
                //temp.velocity = transform.TransformDirection(Vector3.forward  * bulletSpeed * Time.deltaTime);
                
                CloneBullet.SetActive(true);
            }
            // GetPooledBullet();
        }
        if(Input.GetKeyDown(KeyCode.Keypad0))
        {
            Destroy(obj2);
        }
       
    }

    
    

    


}
