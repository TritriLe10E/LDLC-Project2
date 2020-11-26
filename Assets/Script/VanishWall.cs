using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishWall : MonoBehaviour
{
    [SerializeField]
    GameObject wallObject;
    float secondTimer;
    float secondTimer2;

    private void OnTriggerEnter(Collider other)
    {
        wallObject.SetActive(false);
        secondTimer = 12.0f;
        secondTimer2 = 0.0f;
    }

    private void OnTriggerStay(Collider other)
    {
        //doorObject.SetActive(false);
        //Debug.Log("Il y a collision avec " + other.gameObject.name);
    }
    private void OnTriggerExit(Collider other)
    {
        wallObject.SetActive(true);
    }
    private void Update()
    {
        if (secondTimer2 > secondTimer)
        {
            wallObject.SetActive(true);
        }
        secondTimer2 += Time.deltaTime;
    }
}