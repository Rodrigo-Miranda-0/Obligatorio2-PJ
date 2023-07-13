using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEventHandler : MonoBehaviour
{
    public List<float> waveTimings; // List of wave spawn timings in seconds
    public List<GameObject> wavePrefabs; // List of wave prefabs
    private int currentWaveIndex = 0;
    private void Start()
    {
        StartCoroutine(SpawnWavesCoroutine());
    }

    private IEnumerator SpawnWavesCoroutine()
    {
        foreach (float timing in waveTimings)
        {
            yield return new WaitForSeconds(timing);
            SpawnWave();
            currentWaveIndex++;
        }
    }

    private void SpawnWave()
    {
        GameObject wavePrefab = wavePrefabs[currentWaveIndex];
        SpawnWave spawnWave = wavePrefab.GetComponent<SpawnWave>();
        if (spawnWave != null)
        {
            spawnWave.Spawn();
        }
    }
}
