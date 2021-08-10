using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    
    public GameObject hook;
    public GameObject hookHolder;
    public GameObject hookedObj;
    public GameObject orientation;
    public Rigidbody rb;

    public Rigidbody hookrb;

    public float hookTravelSpeed;
    public float playerTravelSpeed;
    public float maxDistance;
    private float currentDistance;
    public float hookUpwardForce;
 //   public float rebounceForce;
   // public float rebounceMultiplier;

    public static bool fired = false;
    public bool hooked = false;
    private bool grounded;



    void Update()
    {
        

        if (Input.GetMouseButton(0) && fired == false)
        {
            fired = true;
        }

        if(fired == true)
        {
            LineRenderer rope = hook.GetComponent<LineRenderer>();
            rope.positionCount = 2;
            rope.SetPosition(0, hookHolder.transform.position);
            rope.SetPosition(1, hook.transform.position);
        }

        if(fired == true && hooked == false)
        {
            hook.transform.Translate(Vector3.forward * Time.deltaTime * hookTravelSpeed);
            currentDistance = Vector3.Distance(transform.position, hook.transform.position);

            if(currentDistance >= maxDistance)
            {
                ReturnHook();
            }

        }

        if(hooked == true && fired == true)
        {
           
            hook.transform.parent = hookedObj.transform;
            transform.position = Vector3.MoveTowards(transform.position, hook.transform.position, playerTravelSpeed * Time.deltaTime);
            float distanceToHook = Vector3.Distance(transform.position, hook.transform.position);

            this.GetComponent<Rigidbody>().useGravity = false;

            if(distanceToHook < 1.5)
            { 
 

                if (grounded == false)
                {
                  this.transform.Translate(Vector3.forward * Time.deltaTime * 100f);
                  this.transform.Translate(Vector3.up * Time.deltaTime * hookUpwardForce);
                    //  this.GetComponent<Rigidbody>().AddForce(orientation.transform.forward * this.GetComponent<WallRunTutorial>().y * rebounceForce * Time.deltaTime * rebounceMultiplier);
                   rb.velocity = new Vector3(0, 0, 0);
                   hookedObj.SetActive(false);



                }

                StartCoroutine("Climb");

            }
        }
        else
        {
            hook.transform.parent = hookHolder.transform;
            this.GetComponent<Rigidbody>().useGravity = true;
        }

        if(!Input.GetMouseButton(0) && fired == true)
        {
            ReturnHook();
        }
    }

    IEnumerator Climb()
    {
        yield return new WaitForSeconds(0.1f);
        ReturnHook();
    }

    void ReturnHook()
    {
        hook.transform.rotation = hookHolder.transform.rotation;
        hook.transform.position = hookHolder.transform.position;
        fired = false;
        hooked = false;
        LineRenderer rope = hook.GetComponent<LineRenderer>();
        rope.positionCount = 0;
        

    }

    void CheckIfGrounded()
    {
        RaycastHit hit;
        float distance = 1f;
        Vector3 dir = new Vector3(0, -1);

        if(Physics.Raycast(transform.position, dir, out hit, distance))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }

    
}
