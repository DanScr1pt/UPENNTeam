using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource SoundFXSource;
    public AudioSource MusicSource;

    public void PlaySoundFX(AudioClip clip)
    {
        SoundFXSource.clip = clip;
        SoundFXSource.Play();
    }

    public void PlayMusic(AudioClip clip)
    {
        MusicSource.clip = clip;
        MusicSource.Play();
    }
}