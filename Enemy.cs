using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    
    public GameObject player;

    //NavMeshAgent agent;

    public GameObject bulletPrefab;

    public bool gunLoaded = true;
    //private AudioSource mAudioSrc;

    // Start is called before the first frame update
    void Start()
    {
      //  mAudioSrc = GetComponent < AudioSource > ();


        //agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            if (Vector3.Distance(player.transform.position, transform.position) < 10)
            {
                // mAudioSrc.Play();
                transform.LookAt(player.transform.position);
                Shoot();
                

            }
            
        }
        
    }

    void Shoot()
    {
        if(gunLoaded)
        {
            GameObject bullet = GameObject.Instantiate(bulletPrefab);
            bullet.transform.position = transform.position;

            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
            
            gunLoaded = false;

            Invoke("Reload", 0.5f);

        }        

    }

    void Reload()
    {
        gunLoaded = true;
    }

}
