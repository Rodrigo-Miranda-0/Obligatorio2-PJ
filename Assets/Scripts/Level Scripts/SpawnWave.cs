using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnWave : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public int numberOfEnemies = 10;
    public Transform pathPrefab; // Assign the PathPrefab for this wave
    private int enemiesSpawned = 0;

    private void AssignPathToEnemy(GameObject enemy)
    {
        // Get the WaypointFollow component from the enemy prefab and set the path prefab
        WaypointFollow waypointFollow = enemy.GetComponent<WaypointFollow>();
        if (waypointFollow != null)
        {
            waypointFollow.SetPathPrefab(pathPrefab);
        }
    }

    public void Spawn()
    {
        StartCoroutine(SpawnEnemiesCoroutine());
    }
    private IEnumerator SpawnEnemiesCoroutine()
    {
        while (enemiesSpawned < numberOfEnemies)
        {
            yield return new WaitForSeconds(spawnInterval);
            
            GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            AssignPathToEnemy(enemy);
            
            enemiesSpawned++;
        }
    }
}
