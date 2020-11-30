using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceCamera : MonoBehaviour
{
    void update()
    {
        transform.LookAt(Camera.main.transform);
    }
}
