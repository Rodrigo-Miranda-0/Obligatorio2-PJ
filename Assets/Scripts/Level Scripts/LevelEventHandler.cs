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
            Debug.Log("Waiting to spawn wave " + currentWaveIndex);
            yield return new WaitForSeconds(timing);
            Debug.Log("wave " + currentWaveIndex);
            SpawnWave();
            currentWaveIndex++;
        }
    }

    private void SpawnWave()
    {
        GameObject wavePrefab = InitializeWavePrefab();
        SpawnWave spawnWave = wavePrefab.GetComponent<SpawnWave>();
        if (spawnWave != null)
        {
            spawnWave.Spawn();
        }
    }

    private GameObject InitializeWavePrefab()
    {
        GameObject wavePrefab = Instantiate(wavePrefabs[currentWaveIndex]);
        wavePrefab.transform.position = transform.position;
        return wavePrefab;
    }
}
