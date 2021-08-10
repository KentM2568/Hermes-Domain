using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{ 
    #region Actual Respawn Code
    [SerializeField]
    public Transform player;
    [SerializeField]
    public Transform respawnPoint;
    public GameObject grapplehookObject;



    void OnTriggerEnter(Collider other)
    {

        player.transform.position = respawnPoint.transform.position;
        grapplehookObject.SetActive(false);
    }
    #endregion Actual Respawn Code
    
    #region GrapplingGun Glitch Debugging
    /*
    public GameObject target;

    public GameObject cameraObject;

    public Transform cameraTransform;



    public GameObject target;
    public string triggerTag;


    
    void OnTriggerEnter(Collider other)

    {
        transform.GetChild(2).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
        Debug.Log("grappling gun do be gone doe");

        
    }

    */

    #endregion GrapplingGun Glitch Debugging
}
