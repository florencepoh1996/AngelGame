using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour {


    public int max_health;
    public static int cur_health;
    public Text healthText;

	// Use this for initialization
	void Start () {
        cur_health = 20;
	}
	
	// Update is called once per frame
	void Update () {
       healthText.text = "HEALTH: " + cur_health.ToString() + "/" + max_health.ToString ();

        

      if(cur_health > 20)
        {
            cur_health = 20;
        }

      if (cur_health <= 0)
        {
            cur_health = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

	}

   



}
