using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpike : MonoBehaviour
{
    // Start is called before the first frame update
    private float destroyTimer = 0f;
    // Update is called once per frame
    void FixedUpdate()
    {
        destroyTimer += Time.deltaTime;
        
        if(destroyTimer >= 5)
        {
            destroyTimer = 0;
            Destroy(gameObject);
        }
    }
}
