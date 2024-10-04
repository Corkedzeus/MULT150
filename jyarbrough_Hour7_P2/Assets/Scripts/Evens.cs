using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x;
        for (x = 22; x <= 100; x+=2) 
        //while (x < 100)
        {
            Debug.Log(x);
        }
        if (x == 100)
        {
            Debug.Log("Congrats on 100!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
