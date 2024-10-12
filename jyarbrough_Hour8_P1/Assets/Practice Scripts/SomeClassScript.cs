using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClassScript : MonoBehaviour
{
    //This is the game object you want to access. This doesn't need to be public when using find()
    private GameObject target;
   
    
    //The following lines create a GameObject Variable as a public class, and allow attaching a game object to the script
    public GameObject objectYouWant;
    public GameObject Flashlight;
    

    // Start is called before the first frame update
    void Start()
    {
        //Extremely slow way to find an object
        //After creating a "private GameObject target;" class
        //by placing the following code in the Start method it saves the results of Find in a variable for future use to minimize impact

        target = GameObject.Find("Cube");

        //FindWithTag Method
        target = GameObject.FindWithTag("MyNewTag");
    }

    // Update is called once per frame
    void Update()
    {
        float mwVal = Input.GetAxis("Mouse Wheel");
        if (mwVal > 0)
            Debug.Log("Scrolling up");
        if (mwVal < 0)
            Debug.Log("Scrolling down");
    }
}
