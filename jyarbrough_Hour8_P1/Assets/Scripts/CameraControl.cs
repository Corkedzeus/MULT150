using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if (mxVal > 0)
        {
            transform.Translate(0.05f, 0f, 0f);
            Debug.Log("Going Right");
        }
        else if (mxVal < 0)
        {
            transform.Translate(-0.05f, 0f, 0f);
            Debug.Log("Going Left");
        }

        if (myVal > 0)
        {
            transform.Translate(0f, 0.05f, 0f);
            Debug.Log("Going Up");
        }
        else if (myVal < 0)
        {
            transform.Translate(0f, -0.05f, 0f);
            Debug.Log("Going Down");
        }
       
    }
}
