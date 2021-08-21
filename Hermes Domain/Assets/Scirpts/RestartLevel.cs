    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    [SerializeField]
    public Transform player;
    [SerializeField]
    public Transform restartPoint;
    [SerializeField]
    public KeyCode restartKey = KeyCode.R;
    public Rigidbody rb;
    public GameObject grapplehookObject;
    public GameObject playerObject;
    public GameObject hookBoxObject1;
    public GameObject hookBoxObject2;
    public GameObject hookBoxObject3;
    public GameObject hookBoxObject4;
    public GameObject hookBoxObject5;
    public GameObject hookBoxObject6;
    public GameObject hookBoxObject7;
    public GameObject grapplingPickUpObject;

    public bool restartedWingsLevel = false;
    public bool restartedBootsLevel = false;


    void Update()
    {
        Restart();
    }

    void LateUpdate()
    {
  //      restartedLevel = false;
    }

    void Restart()
    {
        WallRunTutorial playerScript = playerObject.GetComponent<WallRunTutorial>();
        HermesWingsPickup hermesWingsScript = playerObject.GetComponent<HermesWingsPickup>();
        HermesBootsPickup hermesBootsScript = playerObject.GetComponent<HermesBootsPickup>();
        if (Input.GetKeyDown(restartKey))
        {
            player.transform.position = restartPoint.transform.position;
            rb.velocity = new Vector3(0, 0, 0);
            grapplehookObject.SetActive(false);
            grapplingPickUpObject.SetActive(true);

            hookBoxObject1.SetActive(true);
            hookBoxObject2.SetActive(true);
            hookBoxObject3.SetActive(true);
            hookBoxObject4.SetActive(true);
            hookBoxObject5.SetActive(true);
            hookBoxObject6.SetActive(true);
            hookBoxObject7.SetActive(true);



            if (SceneManager.GetActiveScene().buildIndex == 6 || SceneManager.GetActiveScene().buildIndex == 7 || SceneManager.GetActiveScene().buildIndex == 1)
            {
                HermesItemsCheck();
            }


        }

    //        Debug.Log("Restarted");
            /*
                        playerScript.startDoubleJumps -= 1 * extraJumpMultiplier;
                        playerScript.jumpForce -= 500;
                        playerScript.jumpExtraForwardForce -= jumpExtraForwardForceMultiplier;


                        hermesWingsScript.hasAbsorbedHermesWings = false;
                        //        playerScript.flashCooldown = 1;
            */
    }

    

    public void RestartWithoutKey()
    {
    HermesWingsPickup hermesWingsScript = playerObject.GetComponent<HermesWingsPickup>();
    HermesBootsPickup hermesBootsScript = playerObject.GetComponent<HermesBootsPickup>();

    WallRunTutorial playerScript = playerObject.GetComponent<WallRunTutorial>();
    player.transform.position = restartPoint.transform.position;
    rb.velocity = new Vector3(0, 0, 0);
    grapplehookObject.SetActive(false);
    grapplingPickUpObject.SetActive(true);
    hookBoxObject1.SetActive(true);
    hookBoxObject2.SetActive(true);
    hookBoxObject3.SetActive(true);
    hookBoxObject4.SetActive(true);
    hookBoxObject5.SetActive(true);
    hookBoxObject6.SetActive(true);
    hookBoxObject7.SetActive(true);


        if (SceneManager.GetActiveScene().buildIndex == 6 || SceneManager.GetActiveScene().buildIndex == 7 || SceneManager.GetActiveScene().buildIndex == 1)
        {
            HermesItemsCheck();
        }


        //     Debug.Log("Restarted Without Key");

    }    //        playerScript.flashCooldown = 1;

        

    


    public void HermesItemsCheck()
    {
        HermesWingsPickup hermesWingsScript = playerObject.GetComponent<HermesWingsPickup>();
        HermesBootsPickup hermesBootsScript = playerObject.GetComponent<HermesBootsPickup>();

        if (hermesWingsScript.hasAbsorbedHermesWings == true && hermesWingsScript.soulBool == true)
        {
            restartedWingsLevel = true;
            hermesWingsScript.soulBool = false;
        }

        if (hermesBootsScript.hasAbsorbedHermesBoots == true && hermesBootsScript.soulBool == true)
        {
            restartedBootsLevel = true;
            hermesBootsScript.soulBool = false;
        }

    }

}


