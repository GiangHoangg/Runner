using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float rollSpeed = 40f;   
    void Update()
    {
        if(PlayerMove.canMove){
            float translation = moveSpeed * Time.deltaTime;
            transform.Translate(-Vector3.forward * translation, Space.World);

         
            float rotationAmount = translation * rollSpeed;
            transform.Rotate(Vector3.right, rotationAmount); 
        }
       
    }
}
