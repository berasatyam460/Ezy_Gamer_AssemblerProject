using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBtn : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayAudioOnClick()
    {
        if (audioSource.clip!=null)
        {
            audioSource.Play();
        }
    }
}
