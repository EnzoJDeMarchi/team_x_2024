using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowAndShoot2D : MonoBehaviour
{
    public Transform target; // El objetivo a seguir (el personaje)
    public float speed = 3f; // Velocidad del enemigo
    public float rotationSpeed = 5f; // Velocidad de rotación del enemigo
    public float followDistance = 10f; // Distancia máxima a la que el enemigo sigue al personaje
    public float stopDistance = 1f; // Distancia mínima a la que el enemigo deja de moverse hacia el personaje
    public GameObject projectilePrefab; // Prefab del proyectil
    public float shootingInterval = 2f; // Intervalo de disparo en segundos
    public float projectileSpeed = 5f; // Velocidad del proyectil

    private float shootingTimer;

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
            if (distanceToTarget <= followDistance && distanceToTarget > stopDistance)
            {
                // Rotar gradualmente el enemigo hacia la dirección del objetivo
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

                // Mover al enemigo hacia el objetivo
                Vector3 moveDirection = direction.normalized * speed * Time.deltaTime;
                transform.position += moveDirection;
            }

            // Disparar al objetivo si está dentro de la distancia de seguimiento
            if (distanceToTarget <= followDistance)
            {
                shootingTimer -= Time.deltaTime;
                if (shootingTimer <= 0f)
                {
                    ShootAtTarget(direction);
                    shootingTimer = shootingInterval;
                }
            }
        }
    }

    void ShootAtTarget(Vector3 direction)
    {
        // Instanciar el proyectil y configurarlo para que se mueva hacia el objetivo
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = direction.normalized * projectileSpeed;
        }
    }
}
