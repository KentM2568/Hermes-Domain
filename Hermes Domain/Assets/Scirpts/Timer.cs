using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    bool stopwatchActive = false;
    float currentTime;
    public int StartMinutes;
    public Text currentTimeText;
    
    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Tutorial"))
        {
            StartStopWatch();
        }
        currentTime = 0;
        
    }

   
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            StartStopWatch();
        }




        if (stopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
       TimeSpan time = TimeSpan.FromSeconds(currentTime);
       currentTimeText.text = time.ToString(@"mm\:ss\:ff");


        if (Input.GetKey(KeyCode.Y))
        {
            StopStopWatch();
        }
    }

  //  void LateUpdate()
   // {

  //  }
   // */

    public void StartStopWatch()
    {
        stopwatchActive = true;
    }

    public void StopStopWatch()
    {
        stopwatchActive = false;
    }
}
