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
    public GameObject hookBoxObject1;
    public GameObject hookBoxObject2;
    public GameObject hookBoxObject3;
    public GameObject hookBoxObject4;
    public GameObject hookBoxObject5;
    public GameObject hookBoxObject6;
    public GameObject hookBoxObject7;
    public GameObject playerObject;



    void Update()
    {
//        RestartLevel restartLevelScript = playerObject.GetComponent<RestartLevel>();
    }


    void OnTriggerEnter(Collider other)
    {
        HermesWingsPickup hermesWingsScript = playerObject.GetComponent<HermesWingsPickup>();
        HermesBootsPickup hermesBootsScript = playerObject.GetComponent<HermesBootsPickup>();
        RestartLevel restartLevelScript = playerObject.GetComponent<RestartLevel>();

        player.transform.position = respawnPoint.transform.position;
        grapplehookObject.SetActive(false);
        hookBoxObject1.SetActive(true);
        hookBoxObject2.SetActive(true);
        hookBoxObject3.SetActive(true);
        hookBoxObject4.SetActive(true);
        hookBoxObject5.SetActive(true);
        hookBoxObject6.SetActive(true);
        hookBoxObject7.SetActive(true);
        if (hermesWingsScript.hasAbsorbedHermesWings == true)
        {
            restartLevelScript.restartedLevel = true;
        }

        if (hermesBootsScript.hasAbsorbedHermesBoots == true)
        {
            restartLevelScript.restartedLevel = true;
        }


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
