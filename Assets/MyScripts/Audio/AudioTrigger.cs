using System;
using UnityEngine;
using System.Collections;
using FMOD.Studio;
using FMODUnity;

public enum MusicTypes
{
    Zone1,
    Zone2,
    Zone3,
} 
public class AudioTrigger : MonoBehaviour
{
    AudioManager audioManager;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
      audioManager=GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioManager.Play();
            Debug.Log("playing");
        }
        
    }   
}
