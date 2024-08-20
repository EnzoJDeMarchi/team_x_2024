using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int attackDamage = 20;
    public float attackRange = 1f;
    public LayerMask enemyLayers;
    public Transform attackPoint; // Punto de inicio del ataque (puede ser una posición en frente del personaje)
    public AudioSource attackAudioSource; // Audio source para el sonido de ataque
    public AudioClip attackClip; // Clip de sonido para el ataque

    void Update()
    {
        // Detecta si el jugador presiona el botón de ataque (por defecto, el botón izquierdo del ratón o "Fire1" en Input Manager)
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }

    void Attack()
    {
        // Reproduce el sonido de ataque
        if (attackClip != null && attackAudioSource != null)
        {
            attackAudioSource.PlayOneShot(attackClip);
        }

        // Detecta enemigos en el rango del ataque
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        // Aplica daño a los enemigos
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyHealth>().TakeDamage(attackDamage);
        }
    }

    // Dibuja el rango del ataque en el editor para visualizarlo
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
