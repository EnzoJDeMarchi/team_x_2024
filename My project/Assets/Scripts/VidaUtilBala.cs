using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaUtilBala : MonoBehaviour
{
    public float tiempoDeVida = 3f; // Tiempo de vida de la bala

    void Start()
    {
        Destroy(gameObject, tiempoDeVida); // Destruir la bala después de cierto tiempo
    }
}
