using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject bulletPrefab;

    

    // Start is called before the first frame update
    void Start()
    {
        Shoot();
       
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    
    }

    void Shoot()
    {
        GameObject bullet = GameObject.Instantiate(bulletPrefab);
        bullet.transform.position = transform.position;
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward*600);

        

    }

}
