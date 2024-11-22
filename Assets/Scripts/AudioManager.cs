using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource effectsSource;

    public AudioClip themeMusic;
    public AudioClip click;
    public AudioClip doubleClick;
    public AudioClip investigate;
    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = themeMusic;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip){
        effectsSource.PlayOneShot(clip);

    }//end play SFX
}
