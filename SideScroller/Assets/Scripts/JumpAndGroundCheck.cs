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
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, checkRadius, whatIsGround);
        bool isJumping = Input.GetKeyDown("space");

        if (!isGrounded)
        {
            animator.SetBool("isJumping", true);
            rb.isKinematic = false;
        }
        else
        {
            animator.SetBool("isJumping", false);
            rb.isKinematic = true;
        }
    }   
}
