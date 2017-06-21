using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPass : MonoBehaviour {

    public bool passed = false;

    private AudioSource m_AudioSource;
    public AudioClip winSound;

    private void Awake()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {        
        if (other.gameObject.CompareTag("LabyrinthExit"))
        {
            passed = true;
            PlayWinSound();
        }
    }

    private void PlayWinSound()
    {
        m_AudioSource.clip = winSound;
        m_AudioSource.Play();
    }
}
