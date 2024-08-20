using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float shootInterval = 2f;
    public AudioClip shotSound;
    public AudioSource audioSource;

    void Start()
    {
        InvokeRepeating("Shoot", shootInterval, shootInterval);
        audioSource = GetComponent<AudioSource>();
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        audioSource.PlayOneShot(shotSound);
    }
}
