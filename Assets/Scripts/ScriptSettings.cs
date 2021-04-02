using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ScriptSettings : MonoBehaviour
{
    public AudioSource audioData;
    private float pitchSpeed;

    public void SetSpeed(float sliderValue)
    {
        pitchSpeed = sliderValue;
        UpdatePitchSpeed();
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Update()
    {
        // Ralentir
        if (Input.GetKeyDown("r"))
        {
            pitchSpeed -= 0.1f;
            UpdatePitchSpeed();
        }
        // Accélérer
        else if (Input.GetKeyDown("a"))
        {
            pitchSpeed += 0.1f;
            UpdatePitchSpeed();
        }

        // Retourner au menu
        if (Input.GetKeyDown("b"))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    private void UpdatePitchSpeed()
    {
        // On régule pour pas dépasser le slider
        if (pitchSpeed < 0.5) pitchSpeed = 0.5f;
        if (pitchSpeed > 1.5) pitchSpeed = 1.5f;
        audioData.pitch = pitchSpeed;
    }
}