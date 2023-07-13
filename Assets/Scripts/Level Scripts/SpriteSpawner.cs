using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSpawner : MonoBehaviour
{
    public GameObject floatingPoints;
    public void SpawnPointText(Transform enemyPos, int points)
    {
        GameObject pointsText = Instantiate(floatingPoints, enemyPos.position, Quaternion.identity);
        TextMesh textMesh = pointsText.GetComponent<TextMesh>();
        textMesh.text = points.ToString();
    }

    public void SpawnDeathEffect(Transform enemyPos, GameObject deathEffect)
    {
        GameObject effect = Instantiate(deathEffect, enemyPos.position, Quaternion.identity);
        Destroy(effect, 1f);
    }
}
