using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessManager : MonoBehaviour
{
    public Slider slider;
    public Light[] lightsToAdjust; // Si quieres ajustar el brillo de luces, agrégalas aquí

    private void Start()
    {
        // Cargar el valor del brillo guardado en PlayerPrefs al iniciar
        float savedBrightness = PlayerPrefs.GetFloat("Brightness", 1f); // Valor predeterminado: brillo al 100%
        slider.value = savedBrightness;
        SetBrightness(savedBrightness);
    }

    public void SetBrightness(float brightness)
    {
        // Ajustar el brillo de las luces
        foreach (Light light in lightsToAdjust)
        {
            light.intensity = brightness;
        }

        // Guardar el valor del brillo en PlayerPrefs
        PlayerPrefs.SetFloat("Brightness", brightness);
    }
}
