using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab del enemigo
    public Transform target; // El objetivo a seguir (el personaje)
    public float spawnInterval = 5f; // Intervalo de tiempo entre spawns
    public Vector2 spawnAreaMin; // Coordenadas mínimas del área de spawn
    public Vector2 spawnAreaMax; // Coordenadas máximas del área de spawn

    private float spawnTimer;

    void Start()
    {
        spawnTimer = spawnInterval;
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            SpawnEnemy();
            spawnTimer = spawnInterval;
        }
    }

    void SpawnEnemy()
    {
        // Generar una posición aleatoria dentro del área de spawn
        Vector2 spawnPosition = new Vector2(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y)
        );

        // Instanciar el enemigo
        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        // Asignar el objetivo al enemigo
        EnemyFollow2D enemyFollow = enemy.GetComponent<EnemyFollow2D>();
        if (enemyFollow != null)
        {
            enemyFollow.target = target;
        }
    }
}
