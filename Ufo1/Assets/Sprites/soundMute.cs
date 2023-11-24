using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundMute : MonoBehaviour

{
    public GameObject audioSource;
    
        public void Mute()

    {
        audioSource.GetComponent<AudioSource>().mute = !audioSource.GetComponent<AudioSource>().mute;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
