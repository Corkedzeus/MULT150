using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
  
    //variable for counting collisions
    int collisioncount = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BounceCounter>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        collisioncount++;//increment collision counting
        Debug.Log("Collider solution bounce #: " + collisioncount);
    }
}
