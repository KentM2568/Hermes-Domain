using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplePickup : MonoBehaviour
{
    [SerializeField]
    public GameObject grapplingItem;

    public Collider grapplingOrbCollider;
    //    public GameObject grapplingCrossHair;
    public GameObject grapplingPickUpObject;
    private bool isInRange;

    public void Update()
    { 
        if (isInRange && Input.GetKey(KeyCode.W))
        {
            grapplingItem.SetActive(true);
            //  grapplingCrossHair.SetActive(true);
            grapplingPickUpObject.SetActive(false);

        }

    }




    private void OnTriggerEnter(Collider grapplingOrbCollider)
    {
        if (grapplingOrbCollider.gameObject.tag == "GrapplingOrb")
        {
            isInRange = true;
        }

    }

    private void OnTriggerExit(Collider grapplingOrbCollider)
    {
        if (grapplingOrbCollider.gameObject.tag == "GrapplingOrb")
        {
            isInRange = false;
        }

    }


    // If you want to press a key down to pick it up
    /*
    public void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            grapplingItem.SetActive(true);
        }

    }
    */
}
