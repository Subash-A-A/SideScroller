using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAndGroundCheck : MonoBehaviour
{
    private bool isGrounded;
    public Transform groundCheck;
    float checkRadius = 0.05f;
    public LayerMask whatIsGround;
    Animator animator;

    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, checkRadius, whatIsGround);
        bool isJumping = Input.GetKeyDown("space");
        bool isDashing = Input.GetKeyDown("left shift");

        if (!isGrounded)
        {
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isJumping", false);
        }

        if(isGrounded && isJumping)
        {
            moveDirection.y = jumpSpeed;
        }

        if (isDashing)
        {
            animator.SetTrigger("Dash");
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }   
}
