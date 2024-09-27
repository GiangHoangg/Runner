using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 8;
    public float leftRightSpeed = 20;
    static public bool canMove = false;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if(canMove == true){
            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
                if(this.gameObject.transform.position.x > LevelBound.leftSide){
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
            }
            if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
                if(this.gameObject.transform.position.x < LevelBound.rightSide){
                    transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
                }
                
            }
        }
    }
}
