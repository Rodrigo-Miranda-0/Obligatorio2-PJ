using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float fireRate = 0.5f;
    public float cooldown = 0f;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    public AudioClip shootSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (Input.GetButton("Fire1") && cooldown <= 0)
        {
            cooldown = fireRate;
            Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            audioSource.PlayOneShot(shootSound);
        }
    }
}
