using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 2f; // Tiempo de vida de la bala

    void Start()
    {
        Destroy(gameObject, lifetime); // Destruir la bala después de cierto tiempo
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); // Mover la bala hacia adelante
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Aquí puedes agregar lógica para detectar colisiones con otros objetos
        // Por ejemplo, si colisiona con un enemigo, puedes aplicar daño y destruir la bala
    }
}
