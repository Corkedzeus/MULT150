using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    Light lightComponent;

    //Define variables for light intensity control
    public float minIntensity = 0.5f;  // Minimum intensity value
    public float maxIntensity = 3f;    // Maximum intensity value
    public float intensityStep = 0.1f; // How much the intensity changes with each key press
    //Define variables for light range control
    public float minRange = 2f;  // Minimum range value
    public float maxRange = 10f; // Maximum range value
    public float rangeStep = 1f; // How much the range changes with each key press

    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
        lightComponent.type = LightType.Point;
    }

    // Update is called once per frame
    void Update()
    {
        //On/off funcionality
        if (Input.GetKeyUp(KeyCode.L))
        {
            lightComponent.enabled = !lightComponent.enabled;
        }

        //Intensity adjustment
        /*
        
        //I wanted to make it work with the mouse wheel, and it does. However, left/right arrows seem more suitable.
        
        float mwVal = Input.GetAxis("Mouse Wheel");
        if (mwVal > 0)
        {
            lightComponent.intensity += intensityStep;
            lightComponent.intensity = Mathf.Clamp(lightComponent.intensity, minIntensity, maxIntensity);
            Debug.Log("Increasing Intensity");
        }
            
        if (mwVal < 0)
        {
            lightComponent.intensity -= intensityStep;
            lightComponent.intensity = Mathf.Clamp(lightComponent.intensity, minIntensity, maxIntensity);
            Debug.Log("Decreasing Intensity");
        }
        */

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            lightComponent.intensity += intensityStep;
            lightComponent.intensity = Mathf.Clamp(lightComponent.intensity, minIntensity, maxIntensity);
            Debug.Log("Increasing Intensity" + lightComponent.intensity);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            lightComponent.intensity -= intensityStep;
            lightComponent.intensity = Mathf.Clamp(lightComponent.intensity, minIntensity, maxIntensity);
            Debug.Log("Decreasing Intensity" + lightComponent.intensity);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            lightComponent.range += rangeStep;
            //Not sure that I need to clamp the range values
            lightComponent.range = Mathf.Clamp(lightComponent.range, minRange, maxRange);
            Debug.Log("Increasing Range" + lightComponent.range);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            lightComponent.range -= rangeStep;
            //Not sure that I need to clamp the range values
            lightComponent.range = Mathf.Clamp(lightComponent.range, minRange, maxRange);
            Debug.Log("Decreasing Range" + lightComponent.range);
        }
    }
}
        

    


    
        
    

