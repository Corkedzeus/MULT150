using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ToggleAudio();              
        }
    }
    void ToggleAudio()  //this is how I understand this. Am I right?
                        //void is the return type because we are just using this method as a container for the ToggleAudio function
                        //so that in a larger script we could pass this method with 1 line instead of 4. 
    {
        if (audioSource.isPlaying == true)
            audioSource.Stop();
        else
            audioSource.Play();
    }
}
