using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController character;
    Animator anim;
    PlayerController animationScript;
    JumpAndGroundCheck jumpScript;
    public GameObject spikeSpawner;
    void Start()
    {
        anim = GetComponent<Animator>();
        character = GetComponent<CharacterController>();
        animationScript = GetComponent<PlayerController>();
        jumpScript = GetComponent<JumpAndGroundCheck>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider someObject)
    {
        if (someObject.tag == "Spike")
        {
            jumpScript.enabled = false;
            animationScript.enabled = false;
            character.enabled = false;
            anim.enabled = false;
            spikeSpawner.SetActive(false);
        }
    }
}
