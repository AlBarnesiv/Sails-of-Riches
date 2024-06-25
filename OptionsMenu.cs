using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour{
    public Slider backgroundVolume;
    public Slider soundEffectVolume;
    public Slider ambientVolume;

    void Start(){
        RetrieveBKVolume();
        RetrieveSFXVolume();
        RetrieveABVolume();

        backgroundVolume.onValueChanged.AddListener(delegate { AudioManager.Instance.SetBackgroundVolume(backgroundVolume.value); });
        soundEffectVolume.onValueChanged.AddListener(delegate { AudioManager.Instance.SetSoundEffectVolume(soundEffectVolume.value); });
        ambientVolume.onValueChanged.AddListener(delegate { AudioManager.Instance.SetAmbientVolume(ambientVolume.value); });
    }

    // Retrieve Saved Volumes
    void RetrieveBKVolume(){
        float savedBackgroundVolume = AudioManager.Instance.GetBackgroundVolume();
        backgroundVolume.value = savedBackgroundVolume;
    }

    void RetrieveSFXVolume(){
        float savedSoundEffectVolume = AudioManager.Instance.GetSoundEffectVolume();
        soundEffectVolume.value = savedSoundEffectVolume;
    }

    void RetrieveABVolume(){
        float savedAmbientVolume = AudioManager.Instance.GetAmbientVolume();
        ambientVolume.value = savedAmbientVolume;
    }
}
