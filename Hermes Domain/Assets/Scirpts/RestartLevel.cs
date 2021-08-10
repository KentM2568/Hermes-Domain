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


    void Update()
    {
        Restart();
    }

    void Restart()
    {
        if (Input.GetKeyDown(restartKey))
        {
            player.transform.position = restartPoint.transform.position;
            rb.velocity = new Vector3(0, 0, 0);
        }

    }

    public void RestartWithoutKey()
    {

        player.transform.position = restartPoint.transform.position;
        rb.velocity = new Vector3(0, 0, 0);
   //     grapplehookObject.SetAcitve(false);



    }
}
