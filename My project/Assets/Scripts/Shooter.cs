using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform controldeDisparo;
    [SerializeField] private GameObject[] Balas;
    [SerializeField] private float cargamaxima;
    [SerializeField] private float tiempocarga;
    [SerializeField] AudioSource SonidoDis;


    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (tiempocarga <= cargamaxima)
            {
                tiempocarga += Time.deltaTime;

                SonidoDis.Play();
            }

        }
        if (Input.GetButtonUp("Fire1"))
        {
            Disparar((int)tiempocarga);
            tiempocarga = 0;
        }
    }

    private void Disparar(int tiempocarga)
    {

        Instantiate(Balas[tiempocarga], controldeDisparo.position, controldeDisparo.rotation);
    }
}
