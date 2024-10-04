using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int d = 1;

       while (d < 31)
        {
                    
         if (d == 15)
         {
            Debug.Log("It's my Birthday");
         }
               
         else
         {
            Debug.Log(d);
         }

            d++;
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
