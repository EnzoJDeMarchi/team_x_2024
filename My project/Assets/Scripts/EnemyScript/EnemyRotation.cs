using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    public Transform player;  // Referencia al transform del jugador
    public float rotationSpeed = 360f;  // Velocidad de rotaci�n en grados por segundo

    void Update()
    {
        RotateTowardsPlayer();
    }

    void RotateTowardsPlayer()
    {
        if (player != null)
        {
            // Calcular la direcci�n hacia el jugador
            Vector3 direction = (player.position - transform.position).normalized;

            // Calcular el �ngulo hacia el que el enemigo debe girar
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // Aplicar la rotaci�n suavemente
            Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
