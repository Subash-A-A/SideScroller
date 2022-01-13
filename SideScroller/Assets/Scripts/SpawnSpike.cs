using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpike : MonoBehaviour
{
    public GameObject Spike;
    public float maxTime = 5;
    public float minTime = 2;

    private float time;
    private float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            spawnSpike();
            SetRandomTime();
        }
    }
    
    void spawnSpike()
    {
        time = 0;
        Instantiate(Spike, transform.position, Quaternion.identity, transform);
    }
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }
}
