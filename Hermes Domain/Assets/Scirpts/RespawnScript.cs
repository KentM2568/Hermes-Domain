using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public GameObject hookBoxObject8;
    public GameObject hookBoxObject9;
    public GameObject hookBoxObject10;
    public GameObject hookBoxObject11;
    public GameObject hookBoxObject12;
    public GameObject hookBoxObject13;
    public GameObject hookBoxObject14;
    public GameObject hookBoxObject15;
    public GameObject playerObject;
    public Rigidbody rb;



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
        rb.velocity = new Vector3(0, 0, 0);
        grapplehookObject.SetActive(false);
    //    grapplingPickUpObject.SetActive(true);
        hookBoxObject1.SetActive(true);
        hookBoxObject2.SetActive(true);
        hookBoxObject3.SetActive(true);
        hookBoxObject4.SetActive(true);
        hookBoxObject5.SetActive(true);
        hookBoxObject6.SetActive(true);
        hookBoxObject7.SetActive(true);
        hookBoxObject8.SetActive(true);
        hookBoxObject9.SetActive(true);
        hookBoxObject10.SetActive(true);
        hookBoxObject11.SetActive(true);
        hookBoxObject12.SetActive(true);
        hookBoxObject13.SetActive(true);
        hookBoxObject14.SetActive(true);
        hookBoxObject15.SetActive(true);

        if (SceneManager.GetActiveScene().buildIndex == 6 || SceneManager.GetActiveScene().buildIndex == 7 || SceneManager.GetActiveScene().buildIndex == 1)
        {
            HermesItemsCheck();
        }


    }

    public void HermesItemsCheck()
    {
        HermesWingsPickup hermesWingsScript = playerObject.GetComponent<HermesWingsPickup>();
        HermesBootsPickup hermesBootsScript = playerObject.GetComponent<HermesBootsPickup>();
        RestartLevel restartLevelScript = playerObject.GetComponent<RestartLevel>();

        if (hermesWingsScript.hasAbsorbedHermesWings == true && hermesWingsScript.soulBool == true)
        {
            restartLevelScript.restartedWingsLevel = true;
            hermesWingsScript.soulBool = false;
        }

        if (hermesBootsScript.hasAbsorbedHermesBoots == true && hermesBootsScript.soulBool == true)
        {
            restartLevelScript.restartedBootsLevel = true;
            hermesBootsScript.soulBool = false;
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
