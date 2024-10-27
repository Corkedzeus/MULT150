using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {    
        Debug.Log("Sphere has entered " + gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Sphere remains within " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Sphere has depatred " + gameObject.name);
    }
}
