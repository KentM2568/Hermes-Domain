using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingGun : MonoBehaviour
{
    /*

    
    private LineRenderer lr;
    private Vector3 grapplePoint;
    public LayerMask whatIsGrapplelable;
    public Transform gunTip;
    public Transform camera;
    public Transform player;
    private float maxDistance = 100f;
    private SpringJoint joint;
    public float joinSpring;
    public float jointDamper;
    public float jointMassScale;
    public float maxDistanceMultiplier = 1.25f;
    public Rigidbody notconnectedBody;
    public Vector3 playerVector3;
    public static bool isGrappling;
    public float playerTravelSpeed;
    public LayerMask whatIsGrappleable;
    public Vector3 currentGrapplePosition;
    //   public Vector3 = playerObject.transform.position;





    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            StartGrapple();
            isGrappling = true;
            Debug.Log("epic");

        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopGrapple();
            isGrappling = false;
            
        }

        
    }


    void LateUpdate()
    {
        DrawRope();
    }

   public void StartGrapple()
   {
      //  Debug.Log("hello");

        RaycastHit hit;
        if (Physics.Raycast(GetComponent<Camera>().position, GetComponent<Camera>().forward, out hit, maxDistance, whatIsGrappleable))
        {

            Debug.Log("made it");
            grapplePoint = hit.point;
            joint = player.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = grapplePoint;

            float distanceFromPoint = Vector3.Distance(player.position, grapplePoint);

            //The distance grapple will try to keep from grapple point. 
            joint.maxDistance = distanceFromPoint * 0.8f;
            joint.minDistance = distanceFromPoint * 0.25f;

            //Adjust these values to fit your game.
            joint.spring = 4.5f;
            joint.damper = 7f;
            joint.massScale = 4.5f;

            lr.positionCount = 2;
            currentGrapplePosition = gunTip.position;
            Debug.Log("hello");
            //  player.transform.position = Vector3.MoveTowards(player.transform.position, grapplePoint, playerTravelSpeed * Time.deltaTime);
        }

   }











    void DrawRope()
    {
        //If not grappling, don't draw rope
        if (!joint) return;

        currentGrapplePosition = Vector3.Lerp(currentGrapplePosition, grapplePoint, Time.deltaTime * 8f);

        lr.SetPosition(0, gunTip.position);
        lr.SetPosition(1, currentGrapplePosition);
    }

    void StopGrapple()
    {
        lr.positionCount = 0;
        Destroy(joint);
    }

    public bool IsGrappling()
    {
        return joint != null;
    }

    public Vector3 GetGrapplePoint()
    {
        return grapplePoint;
    }
    */
    
}
