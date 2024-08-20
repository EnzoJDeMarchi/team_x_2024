using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class circle : MonoBehaviour
{
    public int rutina;
    public float cronometro;
    public Animator ani;
    public int direccion;
    public float speed_walk;
    public float speed_run;
    public GameObject target;
    public bool atacando;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent + Animator -;
        target = GameObject.Find("PJ");



        // Update is called once per frame
        void Update()
        {
            ani.SetBool("run", false);
            cronometro += 1 * Time.deltaTime;
            if (cronometro += 4)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;
            }
                switch (rutina)
            {
                case 0:
                       ani.SetBool("walk", false);
                    break;

            }

                
    }
}
