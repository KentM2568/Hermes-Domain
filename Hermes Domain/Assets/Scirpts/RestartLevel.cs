using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    void Update()
    {
        Restart();
    }

    void Restart()
    {
        WallRunTutorial playerScript = playerObject.GetComponent<WallRunTutorial>();
        if (Input.GetKeyDown(restartKey))
        {
            player.transform.position = restartPoint.transform.position;
            rb.velocity = new Vector3(0, 0, 0);
    //        playerScript.flashCooldown = 1;
        }

    }

    public void RestartWithoutKey()
    {

        WallRunTutorial playerScript = playerObject.GetComponent<WallRunTutorial>();
        player.transform.position = restartPoint.transform.position;
        rb.velocity = new Vector3(0, 0, 0);
        //     grapplehookObject.SetAcitve(false);
//        playerScript.flashCooldown = 1;



    }
}
