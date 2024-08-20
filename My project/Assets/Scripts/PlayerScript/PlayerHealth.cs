using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; // Salud máxima del personaje
    public int currentHealth; // Salud actual del personaje

    void Start()
    {
        // Inicializar la salud actual al máximo
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        // Reducir la salud actual por la cantidad de daño recibida
        currentHealth -= damage;

        // Asegurarse de que la salud no sea negativa
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        // Verificar si el personaje ha muerto
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Implementa la lógica de muerte del personaje
        Debug.Log("Player died!");
        // Puedes desactivar el personaje, reproducir una animación de muerte, etc.
        // Por ejemplo: gameObject.SetActive(false);
    }
}
