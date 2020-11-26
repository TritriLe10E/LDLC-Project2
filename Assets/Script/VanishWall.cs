using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishWall : MonoBehaviour
{

    [SerializeField]
    GameObject wallObject;

    private void OnTriggerStay(Collider other)
    {
        wallObject.SetActive(false);
    }
}
