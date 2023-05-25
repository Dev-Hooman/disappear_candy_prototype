using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip disappearSound;



    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        disappearSound = Resources.Load<AudioClip>("DISAPPEAR");



        audioSrc = gameObject.GetComponent<AudioSource>();

    }


    public static void playDisappearSound()
    {
        audioSrc.PlayOneShot(disappearSound);
    }


}


