using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {

  
    public float startingTime = 60f;
    public Text timerText;
  


    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        startingTime -= 1 * Time.deltaTime;
        timerText.text = "Timer: " + startingTime.ToString("0") + " seconds";

        if(startingTime <= 0)
        {
            startingTime = 0;
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        
    }
}
