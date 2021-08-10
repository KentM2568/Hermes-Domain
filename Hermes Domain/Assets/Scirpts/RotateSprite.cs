using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSprite : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
   
        Rotate();
    }
    IEnumerator Climb()
    {
        yield return new WaitForSeconds(10f);
       
    }
    void Rotate()
    {
        transform.Rotate(Vector3.forward * -5f);
        StartCoroutine("Climb");
    }
}
