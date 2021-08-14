using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class HermesWingsPickup : MonoBehaviour
{
    [SerializeField]
    public GameObject hermesWingsItem;
    public GameObject playerObject;
    public Rigidbody playerRB;
    public Transform orientation;
    public Collider hermesWingsCollider;
    public GameObject hermesWingsPickUpObject;
    public VisualEffect lightningEffect;

    public int extraJumpMultiplier;
    public float upwardAntiGravityForce;
    public float jumpExtraForwardForceMultiplier;

    private bool isInRange;
    private bool helperBool = true;
    private bool antiGravBool = false;
    public bool hasAbsorbedHermesWings = false;

    public void Start()
    {

    }
    public void Update()
    {
        RestartLevel restartLevelScript = playerObject.GetComponent<RestartLevel>();
        WallRunTutorial playerScript = playerObject.GetComponent<WallRunTutorial>();
        if (isInRange && helperBool == true && Input.GetKey(KeyCode.F))
        {
            lightningEffect.Play();
            playerScript.startDoubleJumps += 1 * extraJumpMultiplier;
            playerScript.jumpForce += 400;
            playerScript.jumpExtraForwardForce += jumpExtraForwardForceMultiplier;
    //        Debug.Log("epic thing happened");
            hermesWingsPickUpObject.SetActive(false);
            helperBool = false;
            antiGravBool = true;

            hasAbsorbedHermesWings = true;


            

        }

        if(antiGravBool == true)
        {
            playerRB.AddForce(orientation.up * upwardAntiGravityForce * Time.deltaTime);
 //           Debug.Log("gravity is off");
        }

        if(restartLevelScript.restartedLevel == true)
        {
            playerScript.startDoubleJumps -= 1 * extraJumpMultiplier;
            playerScript.jumpForce -= 400;
            playerScript.jumpExtraForwardForce -= jumpExtraForwardForceMultiplier;

            restartLevelScript.restartedLevel = false;

            hermesWingsPickUpObject.SetActive(true);

            Debug.Log("Subtracted Wings");

        }
    }




    private void OnTriggerEnter(Collider hermesWingsCollider)
    {
        if (hermesWingsCollider.gameObject.tag == "HermesWings")
        {
            isInRange = true;
        }

    }

    private void OnTriggerExit(Collider hermesWingsCollider)
    {
        if (hermesWingsCollider.gameObject.tag == "HermesWings")
        {
            isInRange = false;
        }

    }
}
