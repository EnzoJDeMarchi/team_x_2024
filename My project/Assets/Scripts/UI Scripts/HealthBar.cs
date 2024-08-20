using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider; // Referencia al Slider de la barra de vida
    public PlayerHealth playerHealth; // Referencia al componente PlayerHealth del personaje

    void Start()
    {
        // Inicializar el valor máximo del slider
        healthSlider.maxValue = playerHealth.maxHealth;
        healthSlider.value = playerHealth.currentHealth;
    }

    void Update()
    {
        // Actualizar el valor del slider de acuerdo a la salud actual del jugador
        healthSlider.value = playerHealth.currentHealth;
    }
}
