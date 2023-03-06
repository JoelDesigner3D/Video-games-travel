using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RadioSoundScript : MonoBehaviour
{
    
    [SerializeField] AudioClip mario;
    [SerializeField] AudioClip pacman;
    [SerializeField] AudioClip noise1;
    [SerializeField] AudioClip noise2;
    [SerializeField] AudioClip noise3;
    [SerializeField] AudioClip doom;

    [SerializeField] AudioSource audioSource;

    AudioClip currentClip = null;

    [SerializeField] GameObject tunnerButton;
    [SerializeField] TextMeshProUGUI value;
    [SerializeField] TestManager testManager;

 

    private void Update()
    {
        float rotation = tunnerButton.transform.localRotation.z +1;
        Debug.Log("rotation : " + rotation);
        value.text = rotation + "";

   
        if (rotation > 0.5f && rotation < 0.7f)
        {
            PlayClip(pacman);
        }
        else if (rotation >= 0.7f && rotation < 0.9f)
        {
            PlayClip(noise2);
        }
        else if (rotation >= 0.9f && rotation < 1.1f)
        {
            PlayClip(doom);
        }
        else if (rotation >= 1.1f && rotation < 1.3f)
        {
            PlayClip(noise1);
        }
        else if (rotation >= 1.3f && rotation < 1.47f)
        {
            PlayClip(mario);
        }
        else if (rotation >= 1.47f && rotation < 1.5f)
        {
            PlayClip(null);
        }
        else if (rotation >= 1.5f && rotation < 1.7f)
        {
            PlayClip(noise3);
        }
        else
        {
            audioSource.Stop();
            currentClip = null;
        }
    }


    void PlayClip(AudioClip clip)
    {
        
        if (clip == currentClip)
        {
            return;
        }

        audioSource.Stop();

        if (clip == doom)
        {
            testManager.SetPassedTest(true);
        }
        else
        {
            testManager.SetPassedTest(false);
        }

        if (clip != null)
        {
            audioSource.PlayOneShot(clip, 0.7F);
        }
        
        currentClip = clip;
    }

}
