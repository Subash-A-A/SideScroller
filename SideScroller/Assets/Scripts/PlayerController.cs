using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    float velocityZ = 0.0f;
    float acceleration = 0.1f;
    CharacterController character;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = true;
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        bool ragDollActivate = Input.GetKey("left shift");

        if(velocityZ <= 1)
        {
            velocityZ += Time.deltaTime * acceleration;
        }
        if (ragDollActivate)
        {
            character.enabled = false;
            animator.enabled = false;
        }
        else if (!ragDollActivate)
        {
            character.enabled = true;
            animator.enabled = true;
        }

        animator.SetFloat("VelocityZ", velocityZ);
    }
}
