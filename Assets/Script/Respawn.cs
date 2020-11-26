using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 spawn;
    
    
    private void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.tag == "Respawn")
        {
            spawn = transform.position;
        }
     
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -1)
        {
            transform.position = spawn;
        }
        
        Debug.Log(transform.position);
    }
}
