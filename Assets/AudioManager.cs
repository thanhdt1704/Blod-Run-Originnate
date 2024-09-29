using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //tao bien luu tru audiosource
    public AudioSource musicAudioSource;
    public AudioSource vfxAudioSource;

    //tao bien luu tru audioclip
    public AudioClip musicClip;
    public AudioClip coinClip;
    public AudioClip winClip;

        void Start()
    {
        musicAudioSource.clip = musicClip;
        musicAudioSource.Play();
    }

    public void PlayVFX(AudioClip sfxClip)
    {
        vfxAudioSource.clip = sfxClip;
        vfxAudioSource.PlayOneShot(sfxClip);
    }
}
