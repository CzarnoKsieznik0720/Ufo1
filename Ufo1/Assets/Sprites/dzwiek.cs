using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchIOdtwarzanieDzwieku : MonoBehaviour
{
    public AudioClip dzwiekPoKolizji;
        private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
        
    }

    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ObiektB"))
        {
            audioSource.PlayOneShot(dzwiekPoKolizji);
        }
        
    }
     void Update()
    {
        
    }
}
