using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField]
    public GameObject grapplingItem;

    public GameObject grapplingPickUpObject;

    private bool isInRange;

    public void Update()
    { 
        if (isInRange && Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            grapplingItem.SetActive(true);
       //     grapplingPickUpObject.SetAcitve(false);
            
        }

    }




    private void OnTriggerEnter(Collider other)
    {
        isInRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isInRange = false;
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
