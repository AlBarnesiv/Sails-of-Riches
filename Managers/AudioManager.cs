using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour{
    
    // Singleton instance
    public static AudioManager Instance = null;
    public float backgroundVolume = 1.0f;
    public float soundEffectVolume = 1.0f;
    public float ambientVolume = 1.0f;

    void Awake(){

        // Singleton instance
        if (Instance == null){
            Instance = this;
        } else if (Instance != this){
            Destroy(gameObject);
        } DontDestroyOnLoad(gameObject);

        // Get saved volumes
         backgroundVolume = PlayerPrefs.GetFloat("Background Volume", 1.0f);
         soundEffectVolume = PlayerPrefs.GetFloat("Sound Effect Volume", 1.0f);
         ambientVolume = PlayerPrefs.GetFloat("Ambient Volume", 1.0f);
    }

    // Refernces to the volumes
    public float GetBackgroundVolume(){
        return backgroundVolume;
    }

    public float GetSoundEffectVolume(){
        return soundEffectVolume;
    }

    public float GetAmbientVolume(){
        return ambientVolume;
    }

        // Setting volumes on changes
        public void SetBackgroundVolume(float bkVolume){
        backgroundVolume = bkVolume;
        PlayerPrefs.SetFloat("MusicVolume", bkVolume);
    }
        public void SetSoundEffectVolume(float sfxVolume){
        backgroundVolume = sfxVolume;
        PlayerPrefs.SetFloat("MusicVolume", sfxVolume);
    }

        public void SetAmbientVolume(float abVolume){
        backgroundVolume = abVolume;
        PlayerPrefs.SetFloat("MusicVolume", abVolume);
    }
}
