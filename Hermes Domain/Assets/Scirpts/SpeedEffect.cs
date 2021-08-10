using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class SpeedEffect : MonoBehaviour
{
    public Camera playerCamera;

    public Rigidbody rb;

    //  public float startFOV = 60f;
    //public float maxFOV = 90f;

    //    public float t = 0.5f;

    // public epicBool = true;


    public ParticleSystem ps;
    public float fovMin = 70f;
    public float fovMax = 120f;
    public float maxSpeed = 20f;
    public float recoveryRate = 50f;
    private float fov;
    public float epicFloat = 100;
    public bool useFullBool = false;
    public float redoFov;
    public float velocity;



    public double minFOV = 85.0;
    public double maxFOV = 95.0;
  //  public double changeIncrement = 0.3;
    public float changeIncrement = 0.3f;
    // public var previousVelocity = rb.velocity;


    /*

 void FixedUpdate()
 {
 //    var previousVelocity = rb.velocity;

     float acceleration = rb.velocity.magnitude;

     float changeIncrement = acceleration;





     minFOV = 85.0;
     maxFOV = 95.0;
     var emission = ps.emission;

     if (Input.GetKey(KeyCode.W) && playerCamera.fieldOfView < maxFOV && useFullBool == false)
     {
         playerCamera.fieldOfView += changeIncrement;
         emission.rateOverTime = Mathf.MoveTowards(playerCamera.fieldOfView, fov, Time.deltaTime * recoveryRate);

         ps.gameObject.SetActive(true);
         emission.enabled = true;
         useFullBool = true;

     }
     if (Input.GetKeyUp(KeyCode.W) && useFullBool == true)
     {
         playerCamera.fieldOfView = 80;

         ps.gameObject.SetActive(false);
         useFullBool = false;

     }

 }
 */

    void FixedUpdate()
    {
        velocity = rb.velocity.magnitude;
      ///     Debug.Log(playerCamera.fieldOfView.ToString());
      ///     

        if (velocity >= 5.1f && useFullBool == false)
         {

            ActivatePartical();
            useFullBool = true;
          //  Debug.Log("things happened");

         }
        if (velocity <= 5 && useFullBool == true)
         {
            StopPartical();
            useFullBool = false;
          //ebug.Log("on yeet");

        }

        if (useFullBool == true)
        {
            Zoom();
        }

        Debug.Log(velocity.ToString());
    }





 public void Zoom()
 {   
     var emission = ps.emission;
     float epicNumber = (rb.velocity.magnitude / maxSpeed);
     fov = fovMin + (epicNumber * (fovMax - fovMin));
     

     playerCamera.fieldOfView = Mathf.MoveTowards(playerCamera.fieldOfView, fov, Time.deltaTime * recoveryRate);
     emission.rateOverTime = Mathf.MoveTowards(playerCamera.fieldOfView, fov, Time.deltaTime * recoveryRate);


       
   }

 public void ActivatePartical()
 {
     var emission = ps.emission;
     ps.gameObject.SetActive(true);
     emission.enabled = true;
 }

 public void StopPartical()
 {
     var emission = ps.emission;
     ps.gameObject.SetActive(false);
     emission.enabled = true;
     playerCamera.fieldOfView = Mathf.MoveTowards(playerCamera.fieldOfView, redoFov , Time.deltaTime * recoveryRate);
        //    Debug.Log("epic");
    }

 


    /*

        void Update()
        {
            epicBool = true;

            if (Input.GetKey(KeyCode.UpArrow))
            {
                playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, maxFOV, t);
            }
            else
                playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, startFOV, t);


        if (Input.GetKey(KeyCode.W) && rb.velocity.magnitude > 50)
            {

                Debug.Log("penis");
                playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, maxFOV, t);
            }
            else
            {
                 playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, startFOV, t);
            }

        }        void Awake()
        {
            rb.velocity.magnitude = velocity;
            playerCamera.fieldOfView = fov;
        }
    

    // Update is called once per frame
    void Update()
    {
        rb.velocity.magnitude = velocity;
        playerCamera.fieldOfView = fov;

        velocity = fov;
    }

    */



}










