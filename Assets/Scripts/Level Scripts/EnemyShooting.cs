using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public float fireRate = 0.5f;
    public float cooldown = 5f;
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
        if (cooldown <= 0)
        {
            Vector3 targetPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
            transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPosition - transform.position);
            cooldown = fireRate;
            Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            audioSource.PlayOneShot(shootSound);
        }
    }
}
