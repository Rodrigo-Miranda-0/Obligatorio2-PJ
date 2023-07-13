using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject whiteLaser;
    public GameObject greenLaser;
    public GameObject repairKit;
    public GameObject star;
    public int spawnTimer = 20;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(SpawnPowerUp());
    }

    private IEnumerator SpawnPowerUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTimer);
            int randomPowerUp = Random.Range(0, 4);
            switch (randomPowerUp)
            {
                case 0:
                    Instantiate(whiteLaser, RandomPosition(), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(greenLaser, RandomPosition(), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(repairKit, RandomPosition(), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(star, RandomPosition(), Quaternion.identity);
                    break;
            }
        }
    }

    Vector3 RandomPosition()
    {
        float randomX = Random.Range(-2.2f, 2.2f);
        Vector3 randomPosition = new Vector3(randomX, 5, 0);
        return randomPosition;
    }
}
