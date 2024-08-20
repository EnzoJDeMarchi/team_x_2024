using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private GameObject efectomuerte;
    public int points = 10;

    public void TomarDa�o(float Da�o)
    {
        vida -= Da�o;
        if (vida <= 0)
        {
            Muerte();
        }
    }
    private void Muerte()
    {
        Instantiate(efectomuerte, transform.position, Quaternion.identity);
        Destroy(gameObject);
       

    }

}
