﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    Rigidbody bullet;
    
    
    // Start is called before the first frame update
    void Start()
    {
         bullet = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = 4f;
        
        Vector3 currentPosition = transform.position;

        Vector3 moveForward = transform.forward;

        Vector3 newPosition = currentPosition + moveForward * speed * Time.deltaTime;

        bullet.MovePosition(newPosition);
    }
}
