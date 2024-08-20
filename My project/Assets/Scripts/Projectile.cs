using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 5f; // Velocidad del proyectil
    public int damage = 10; // Da�o infligido al personaje
    public AudioClip hitSound; // Sonido al impactar

    private Transform target; // Referencia al personaje
    private Vector3 direction; // Direcci�n hacia el personaje

    void Start()
    {
        // Obtener la posici�n del personaje
        target = GameObject.FindGameObjectWithTag("Player").transform;

        // Calcular la direcci�n hacia el personaje
        direction = (target.position - transform.position).normalized;

        // Rotar el proyectil hacia el personaje
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    void Update()
    {
        // Mover el proyectil en direcci�n hacia el personaje
        transform.position += direction * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si ha colisionado con el personaje
        if (other.CompareTag("Player"))
        {
            // Obtener el componente PlayerHealth del personaje
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            // Verificar si se encontr� el componente
            if (playerHealth != null)
            {
                // Aplicar da�o al personaje
                playerHealth.TakeDamage(damage);

                // Reproducir sonido de impacto
                AudioSource.PlayClipAtPoint(hitSound, transform.position);
            }

            // No destruir el proyectil al impactar
            return;
        }

        // Destruir el proyectil al tocar otro objeto
        Destroy(gameObject);
    }
}
