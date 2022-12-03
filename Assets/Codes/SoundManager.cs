using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour 
{
   public static AudioClip Backgroundsound , Deadsound , point;
    static AudioSource audioSrc;

    void Start ()
    {
        Backgroundsound = Resources.Load<AudioClip>("Backgroundsound");
        Deadsound = Resources.Load<AudioClip>("Deadsound");
        point = Resources.Load<AudioClip>("point");

        audioSrc = GetComponent<AudioSource>();
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Background":
                audioSrc.PlayOneShot(Backgroundsound);
                break;
            case "Dead":
                audioSrc.PlayOneShot(Deadsound);
                break;
            case "Point":
                audioSrc.PlayOneShot(point);
                break;
        }
    }
}
