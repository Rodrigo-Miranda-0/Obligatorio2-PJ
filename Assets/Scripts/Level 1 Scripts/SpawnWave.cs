using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWave : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public int numberOfEnemies = 10;
    public Transform pathPrefab; // Assign the PathPrefab for this wave

    private float spawnTimer = 0f;
    private int enemiesSpawned = 0;

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval && enemiesSpawned < numberOfEnemies)
        {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            AssingPathToEnemy(enemy);
            spawnTimer = 0f;
            enemiesSpawned++;
        }
    }
    
    void AssingPathToEnemy(GameObject enemy)
    {
        // Get the WaypointFollow component from the enemy prefab and set the path prefab
        WaypointFollow waypointFollow = enemy.GetComponent<WaypointFollow>();
        if (waypointFollow != null)
        {
            waypointFollow.SetPathPrefab(pathPrefab);
        }
    }
}
