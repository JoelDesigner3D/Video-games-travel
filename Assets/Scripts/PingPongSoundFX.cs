using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PingPongSoundFX : MonoBehaviour
{

    public AudioClip ballSoundFX;
    AudioSource audioSource;

    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        Debug.Log("Collision enter");
        // ballSoundFX.Play();

        audioSource.PlayOneShot(ballSoundFX, 0.7F);

    }

    


}
