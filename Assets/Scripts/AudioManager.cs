using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource effectsSource;

    public AudioClip theme;
    public AudioClip click;
    public AudioClip investigate;
    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = theme;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}