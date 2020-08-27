using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    Rigidbody body;

    public float speed;

    public Camera camera;


	// Use this for initialization
	void Start () {

        body = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {

        PlayerMove();
        PlayerRotate();

     

    }

    void PlayerMove()
    {

        Vector3 myVelocity = Vector3.zero;
   

        if(Input.GetKey(KeyCode.W))
        {
            myVelocity += transform.forward * 5;
        }
        if (Input.GetKey(KeyCode.S))
        {
            myVelocity += transform.forward * -5;
        }
        if (Input.GetKey(KeyCode.D))
        {
            myVelocity += transform.right * 5;
        }
        if (Input.GetKey(KeyCode.A))
        {
            myVelocity += transform.right * -5;
        }

        body.velocity = myVelocity;

    }

    void PlayerRotate()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
        
                 Vector3 hitPoint = hit.point;

                 hitPoint.y = transform.position.y;

                transform.LookAt(hitPoint);
       
           
        }

    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Star")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

        }

        if (collision.gameObject.name == "Heart")
        {
            Destroy(collision.gameObject);
            DisplayHealth.cur_health += 2;

        }


    }

}
