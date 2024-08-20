using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 10; // Daño que el enemigo inflige

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el enemigo colisiona con el jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            // Obtener el componente PlayerHealth del jugador
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                // Infligir daño al jugador
                playerHealth.TakeDamage(damage);
            }
        }
    }
}
