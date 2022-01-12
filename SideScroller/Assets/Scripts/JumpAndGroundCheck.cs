using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAndGroundCheck : MonoBehaviour
{
    private bool isGrounded;
    public Transform groundCheck;
    float checkRadius = 0.01f;
    public LayerMask whatIsGround;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, checkRadius, whatIsGround);
        if (!isGrounded)
        {
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isJumping", false);
        }
    }
}
