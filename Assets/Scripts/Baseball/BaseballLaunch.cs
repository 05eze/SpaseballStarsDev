using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class BaseballLaunch : MonoBehaviour
{
    public Transform baseballSpawnPoint;
    public GameObject baseballPrefab;
    public float baseballSpeed;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var baseball = Instantiate(baseballPrefab, baseballSpawnPoint.position, baseballSpawnPoint.rotation);
            baseball.GetComponent<Rigidbody>().velocity = baseballSpawnPoint.forward * baseballSpeed;
        }
    }
}
