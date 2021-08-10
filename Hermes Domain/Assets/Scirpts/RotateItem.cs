using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour
{

    void Update()
    {
        float z = Mathf.PingPong(t: Time.time, length: 1f);
        Vector3 axis = new Vector3(x: 1f, y: 1f, z);
        transform.Rotate(axis, angle: 0.75f);

    }
}
