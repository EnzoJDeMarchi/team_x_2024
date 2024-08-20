using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform target; // El objetivo a seguir (el personaje)
    public float speed = 5f; // Velocidad del enemigo
    public float rotationSpeed = 10f; // Velocidad de rotaci�n del enemigo

    void Update()
    {
        // Asegurarse de que el objetivo est� asignado
        if (target != null)
        {
            // Calcular la direcci�n hacia el objetivo
            Vector3 direction = target.position - transform.position;
            direction.y = 0; // Ignorar la componente y para evitar que el enemigo se incline

            // Rotar gradualmente el enemigo hacia la direcci�n del objetivo
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Mover al enemigo hacia el objetivo
            Vector3 moveDirection = direction.normalized * speed * Time.deltaTime;
            transform.position += moveDirection;
        }
    }
}
