using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class TitleScreenBackground : MonoBehaviour{
    public AudioSource audioSource;
    public AudioClip background;

    void Start(){
        PlayMusic();
    }

    void Update(){
        VolumeControl();
    }

    void PlayMusic(){
        if(audioSource != null && background != null){
            audioSource.clip = background;
            audioSource.loop = true;
            VolumeControl();
            audioSource.Play();
        }
    }

    void VolumeControl(){
        float savedVolume = AudioManager.Instance.GetBackgroundVolume();
        audioSource.volume = savedVolume;
    }
}
