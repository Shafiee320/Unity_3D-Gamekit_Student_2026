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
    public struct MusicData
    {
        public MusicTypes music;

    }
    
    [SerializeField] EventInstance eventInstance;
    [SerializeField] EventReference eventRef;
    
    MusicTypes musicType;
    MusicData[] musics;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eventInstance=RuntimeManager.CreateInstance("eventInstance");
        eventInstance.start();
        
        eventInstance.getPlaybackState(out PLAYBACK_STATE playbackState);
        Debug.Log(playbackState);
        
        
        foreach (MusicData musicData in musics )
        {
            switch (musicData.music)
            {
                case MusicTypes.Zone1:
                    //runk
                    Debug.Log("Zone 1");
                    break;
            }
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
