using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;
using Gamekit3D;

[System.Serializable] 
public struct MusicData
{
    public MusicTypes music;
    public EventReference eventRef;
}

[System.Serializable]
public struct EventInstances
{
    public MusicTypes music;
    public EventInstance[] eventInstances;
}

public class AudioManager : MonoBehaviour
{
   
    MusicTypes musicType;
    
    [SerializeField] MusicData[] musics;
    List<EventInstances> eventInstances = new List<EventInstances>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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

    public void Play()
    {
       /* EventInstance eventInstance = RuntimeManager.CreateInstance();
        var ei = new EventInstances();
        ei.music = musicType;
        ei.eventInstances = eventInstance;
        eventInstances.Add(ei);
        eventInstance.start();
        eventInstance.release();*/ 
       
       //fixa med enums så att man vet vilket eventref vi syftar på
        //döp om din lista så du inte får huvudvärk
        
        Debug.Log("Play");
    }
}
