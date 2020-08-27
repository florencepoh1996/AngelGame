using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    

    public int damage = 2;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnCollisionEnter(Collision collision)
    {

      if (collision.gameObject.name == "Player")
       {
            DisplayHealth.cur_health -= damage;

        }

      if (DisplayHealth.cur_health == 0)
        {
            Destroy(collision.gameObject);
            
        }
      

    }

}
