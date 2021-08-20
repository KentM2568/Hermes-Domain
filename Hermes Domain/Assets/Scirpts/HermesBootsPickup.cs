using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class HermesBootsPickup : MonoBehaviour
{
    [SerializeField]
    public GameObject hermesBootsItem;
    public GameObject playerObject;
    public Collider hermesBootsCollider;
    public GameObject hermesBootsPickUpObject;
    public bool hasAbsorbedHermesBoots = false;
    public bool soulBool = false;
    public VisualEffect lightningEffect;



    public float speedMultiplier;

    private bool isInRange;
    private bool helperBool = true;

    public void Start()
    {
        
    }
    public void Update()
    {
        RestartLevel restartLevelScript = playerObject.GetComponent<RestartLevel>();
        WallRunTutorial playerScript = playerObject.GetComponent<WallRunTutorial>();
        if (isInRange && helperBool == true && Input.GetKey(KeyCode.E))
        {
            lightningEffect.Play();
            playerScript.moveSpeed += 250 * speedMultiplier;
            playerScript.sonicSpeedForce += 100 * speedMultiplier;
            playerScript.maxSonicSpeed += 100000;
            playerScript.timeBetweenNextSonicBoost += 0.35f;
            playerScript.wallrunForwardMultiplier += 1f;
 //           Debug.Log("penis fart");
            hermesBootsPickUpObject.SetActive(false);
            helperBool = false;
            
            hasAbsorbedHermesBoots = true;
            soulBool = true;
        }

        if (restartLevelScript.restartedBootsLevel == true)
        {
            playerScript.moveSpeed -= 250 * speedMultiplier;
            playerScript.sonicSpeedForce -= 100 * speedMultiplier;
            playerScript.maxSonicSpeed -= 100000;
            playerScript.timeBetweenNextSonicBoost -= 0.35f;

            restartLevelScript.restartedBootsLevel = false;
            helperBool = true;
            hermesBootsPickUpObject.SetActive(true);

            Debug.Log("Subtracted Boots");

        }

    }




    private void OnTriggerEnter(Collider hermesBootsCollider)
    {
        if (hermesBootsCollider.gameObject.tag == "HermesBoots" )
        {
            isInRange = true;
           
        }

    }

    private void OnTriggerExit(Collider hermesBootsCollider)
    {
        if (hermesBootsCollider.gameObject.tag == "HermesBoots")
        {
            isInRange = false;
        }

    }
}
