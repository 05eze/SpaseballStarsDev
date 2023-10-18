using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class BaseballLaunch : MonoBehaviour
{
    public Transform baseballSpawnPoint;
    public GameObject baseballPrefab;
    public float baseballSpeed;
    public float spawnTime;
    public float spawnDelay;
    public bool stopSpawning = false;
    public float delayAndSpawnRate = 5;
    

    /*void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);

        spawnRateCountdown -= Time.deltaTime;
    }

    void Update()
    {
        if(spawnRateCountdown -= Time.deltaTime > 0)
        {
            var baseball = Instantiate(baseballPrefab, baseballSpawnPoint.position, baseballSpawnPoint.rotation);
            baseball.GetComponent<Rigidbody>().velocity = baseballSpawnPoint.forward * baseballSpeed;
            if (stopSpawning)
            {
                CancelInvoke("SpawnObject");
            }
        }
       
        
    }*/
}
