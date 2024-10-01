using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 8;
    public float leftRightSpeed = 20;
    static public bool canMove = false;
    private Rigidbody rb;
    public bool isJumping = false;
    public bool comingDown = false;

    public GameObject playerObject;

    private float initialYPosition; // Lưu vị trí Y ban đầu

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialYPosition = transform.position.y; // Gán vị trí Y ban đầu khi game bắt đầu


    }

    // Update is called once per frame
    void Update()
    {
       if(canMove){
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

             if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space)){
                if(isJumping == false){
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(JumpSequence());
                }
             }
        }

        if (isJumping == true){
            if(comingDown == false){
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
            }
            if(comingDown == true){
                transform.Translate(Vector3.down * Time.deltaTime * 3, Space.World);
            }
        }
       }
        
    }

    IEnumerator JumpSequence(){
        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        comingDown = false;

        // Đặt lại vị trí Y sau khi nhảy xong
        Vector3 newPosition = transform.position;
        newPosition.y = initialYPosition; // Đặt Y về giá trị ban đầu
        transform.position = newPosition;

        playerObject.GetComponent<Animator>().Play("Standard Run");

    }
    
}