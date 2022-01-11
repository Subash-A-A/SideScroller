using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    float velocityZ = 0.0f;
    float acceleration = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(velocityZ <= 1)
        {
            velocityZ += Time.deltaTime * acceleration;
        }
        animator.SetFloat("VelocityZ", velocityZ);
    }
}
