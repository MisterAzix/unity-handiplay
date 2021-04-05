using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;
    public AudioSource m_soundStream;
    public AudioSource m_FXStream;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlayFX(){
        m_FXStream.Play();

    }
    public void PlaySound(AudioClip soundClipToPlay)
    {
        m_soundStream.clip = soundClipToPlay;
        m_soundStream.Play();
    }

}
