using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float speed = 5f;

    void Update()
    {
        rb.velocity = new Vector3(0, 0, -speed * Time.deltaTime);
    }
}
