using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //Declare healthpoints variable
    int healthpoints = 3992;


    // Start is called before the first frame update
    void Start()
    {
        //This is speciffically what was asked for, but i wanted to try to shorten it with a loop. initially, I forgot to use a "while" loop. 
        /*   
            //Call UsePotion and assign the result back to healthpoints
            healthpoints = UsePotion(healthpoints);
            healthpoints = UsePotion(healthpoints);
            healthpoints = UsePotion(healthpoints);
            healthpoints = UsePotion(healthpoints);


            Debug.Log(healthpoints);
        */
        while (healthpoints < 5992)
        {
            healthpoints = UsePotion(healthpoints);

            // Check if healthpoints has reached or exceeded 5992
            if (healthpoints >= 5992)
            {
                // Print the final value to the console
                Debug.Log(healthpoints);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //method to use a potion to increase health
    int UsePotion(int health)
    {
        health += 400; //add 400 to current health value
        return health; //return new health value
    }
}


