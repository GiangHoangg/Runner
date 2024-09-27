using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROutateObject : MonoBehaviour
{
    public int rorateSpeed = 1;
    void Start()
    {
        rorateSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rorateSpeed, 0, Space.World);
    }
}
