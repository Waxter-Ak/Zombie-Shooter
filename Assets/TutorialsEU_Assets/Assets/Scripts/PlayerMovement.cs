using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    public float Speed = 12f;
    public CharacterController controller;
    public float gravity = -9.81f;
    Vector3 velocity;
    public bool isGrounded;
    public float GroundDistance = 0.4f;
    public Transform GroundCheck;
    public LayerMask GroundMask;
    public AudioSource GroundSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        isGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);
        if(isGrounded && velocity.y <0 )
        {
            velocity.y = -2f;
        }
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right*moveX + transform.forward*moveZ;
        controller.Move(move*Speed*Time.deltaTime);
        velocity.y += gravity*Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = 4;
            GroundSound.Play();
            
        }
    }
}
