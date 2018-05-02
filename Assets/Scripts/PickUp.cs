using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public GameObject bulletOne, bulletTwo, bulletThree, gunOne, gunTwo, gunThree, healthOrb, bigHealthOrb, healthCube;
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
           
        }
    }
}

