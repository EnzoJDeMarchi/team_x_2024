using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow2D : MonoBehaviour
{
    public Transform target; // El objetivo a seguir (el personaje)
    public float speed = 3f; // Velocidad del enemigo
    public float rotationSpeed = 5f; // Velocidad de rotación del enemigo
    public float followDistance = 10f; // Distancia máxima a la que el enemigo sigue al personaje

    void Update()
    {
        // Asegurarse de que el objetivo esté asignado
        if (target != null)
        {
            // Calcular la dirección hacia el objetivo
            Vector3 direction = target.position - transform.position;
            direction.z = 0; // Ignorar la componente z para mantener el movimiento en 2D

            // Calcular la distancia al objetivo
            float distanceToTarget = direction.magnitude;

            // Solo seguir al objetivo si está dentro de la distancia permitida
            if (distanceToTarget <= followDistance)
            {
                // Rotar gradualmente el enemigo hacia la dirección del objetivo
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

                // Mover al enemigo hacia el objetivo
                Vector3 moveDirection = direction.normalized * speed * Time.deltaTime;
                transform.position += moveDirection;
            }
        }
    }
}
