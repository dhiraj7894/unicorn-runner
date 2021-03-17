using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip clip;
    public AudioClip _HorseClip;
    public AudioClip poleRemoverClip;
    public void playAuido()
    {
        Audio.PlayOneShot(clip);
    }
}
