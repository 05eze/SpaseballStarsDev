using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseballFunctions : MonoBehaviour
{
    public GameObject homerunTarget;
    public GameObject tripleTarget;
    public GameObject doubleTarget;
    public GameObject singleTarget;
    public GameObject outArea;

    //If Ball collides with arena collider, delete it for four seconds, make out annoncement appear for four seconds, resume.
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Ball" + "Single")
        {
            Debug.Log("Single!");
            HideAndShow(4.0f); //4 seconds hidden

        }
    }

    //Hide object
    private void HideAndShow(float delay)
    {
        gameObject.SetActive(false);

        //Show after the delay
        Invoke(nameof(HideAndShow), delay);
    }

    //Show parameter 
    private void Show()
    {
        gameObject.SetActive(true);
    }    



   
}
