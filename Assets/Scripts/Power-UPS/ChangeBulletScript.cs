using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBulletScript : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private AudioClip shootSound;
    [SerializeField] private float fireRate;
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerShooting playerShooting = other.GetComponent<PlayerShooting>();
        if (playerShooting != null)
        {
            playerShooting.bulletPrefab = bulletPrefab;
            playerShooting.shootSound = shootSound;
            playerShooting.fireRate = fireRate;
        }

        Destroy(gameObject);
    }
}
