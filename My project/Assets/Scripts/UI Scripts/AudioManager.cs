using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider slider;

    private void Start()
    {
        // Cargar el valor del volumen guardado en PlayerPrefs al iniciar
        float savedVolume = PlayerPrefs.GetFloat("Volume", 1f); // Valor predeterminado: volumen al 100%
        slider.value = savedVolume;
        SetVolume(savedVolume);
    }

    public void SetVolume(float volume)
    {
        if (audioMixer == null)
        {
            Debug.LogError("Audio Mixer no está asignado en el Inspector.");
            return;
        }

        audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("Volume", volume);
     

    }
}
