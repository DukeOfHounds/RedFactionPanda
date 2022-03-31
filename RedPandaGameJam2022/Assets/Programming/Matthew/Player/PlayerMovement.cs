using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    private PlayerInput pI;
    public CharacterController controller;
    //public Transform camPivot ;
    public Transform playerBody;
    Vector3 velocity;
    float gravity = -9.81f;
    //float horizontalMovement = 0;
    //float verticalMovement = 0;
    public float jumpForce = 7;

    //bool isGrounded;d
    //bool isMoving = false;

    //float iTimer;
    //float iTimerMax = 2;
    //bool useTimer;


    private void Awake()
    {
        PlayerInput.JumpEvent += HandleJump;//

    }

    private void Start()
    {
        pI = this.gameObject.GetComponent<PlayerInput>();
        controller = this.gameObject.GetComponent<CharacterController>();
        pI.pD.currentMovement = gameObject.transform.position;
    }


    void Update()
    {
        HandleMovement();
        //Debug.Log(speed);
        Look();
    }

    void Look()
    {
        Vector3 rawMovement = new Vector3(-pI.GetHorizontalMovement() * .75f, 0.0f, -pI.GetVerticalMovement());
        if (rawMovement != Vector3.zero)
        {
            var relative = (transform.position + rawMovement)-transform.position;
            var rot = Quaternion.LookRotation(relative, Vector3.up);

            playerBody.rotation = rot;
        }
    
    }
    private void HandleMovement()
    {
        Vector3 rawMovement = new Vector3(pI.GetHorizontalMovement() * .75f, 0.0f, pI.GetVerticalMovement());
        pI.pD.currentMovement = Vector3.MoveTowards(pI.pD.currentMovement, rawMovement, pI.pD.inertiaVar * Time.deltaTime);
        Vector3 finalMovement = transform.TransformVector(pI.pD.currentMovement);
        controller.Move(finalMovement * pI.pD.moveSpeed * Time.deltaTime);
        velocity.y += gravity*Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
    private void HandleJump(object sender, EventArgs e)
    {
        Debug.Log("Jump");
        if (controller.velocity.y <= 0)
        {
            velocity.y = jumpForce;
            controller.Move(velocity * Time.deltaTime);
        }
    }




}
