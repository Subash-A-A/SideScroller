using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    float velocityZ = 0.0f;
    float acceleration = 0.1f;
    CharacterController character;
    JumpAndGroundCheck jumpScript;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        character = GetComponent<CharacterController>();
        jumpScript = GetComponent<JumpAndGroundCheck>();
        animator.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        bool ragDollActivate = Input.GetKey("q");

        if(velocityZ <= 1)
        {
            velocityZ += Time.deltaTime * acceleration;
        }
        if (ragDollActivate)
        {
            jumpScript.enabled = false;
            character.enabled = false;
            animator.enabled = false;
        }
        else if (!ragDollActivate)
        {
            jumpScript.enabled = true;
            character.enabled = true;
            animator.enabled = true;
        }
        if(Input.GetKeyDown("left shift"))
        {
            animator.SetTrigger("Roll");
        }

        animator.SetFloat("VelocityZ", velocityZ);
    }
}
