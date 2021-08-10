using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCollider : MonoBehaviour
{
    [SerializeField]
    public Transform player;
    [SerializeField]
    public Transform exitPoint;
    //[SerializeField]
    //public Transform respawnPoint;

    public int buildIndexAddition;


    public bool isInRange;


    void Update()
    {
        if (isInRange)
        {
            EnterLevelOne();
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

    public void EnterLevelOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + buildIndexAddition);
        //player.transform.position = respawnPoint.transform.position;

    }

}