using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public int health = 1;
    public int collisionDamage = 1;
    public AudioClip deathSound;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    private IEnumerator DelayedDestroy(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }

    private void Die()
    {
        // if (audioSource != null && deathSound != null)
        // {
        //     audioSource.PlayOneShot(deathSound);
        //     StartCoroutine(DelayedDestroy(deathSound.length)); // Delay destruction by the sound length
        // }
        Destroy(gameObject);
    }
}
