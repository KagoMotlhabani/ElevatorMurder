using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeController : MonoBehaviour
{
    public AudioMixer myMixer;
    public Slider musicSlider;

    public Slider masterSlider;
    public Slider sfxSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMusicVolume(){
        float volume = musicSlider.value;
        myMixer.SetFloat("musicVolume", Mathf.Log10(volume)*20);
    }
    public void SetMasterVolume(){
        float volume = musicSlider.value;
        myMixer.SetFloat("masterVolume", Mathf.Log10(volume)*20);
    }
    public void SetSFXVolume(){
        float volume = musicSlider.value;
        myMixer.SetFloat("sfxVolume", Mathf.Log10(volume)*20);
    }



}
