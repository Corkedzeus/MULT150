using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMode : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //Get reference to animator
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Color");
        }
    }
}

/*
 I chose to use the hour 3 scene because I wanted to try creating multiple controllers. I initially splis the control scripts up and left them that way, 
 although I am aware that I could combine them into a single script. 
*/