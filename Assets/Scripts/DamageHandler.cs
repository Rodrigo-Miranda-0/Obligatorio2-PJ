using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public int health = 1;
    public int maxHealth = 1;
    public int collisionDamage = 1;
    public int scoreValue = 1;
    public AudioClip deathSound;
    public GameObject deathEffect;
    private GameObject soundPlayer;
    private GameObject spriteSpawner;
    private Animator animator;

    [SerializeField] FloatingHealthbar healthbar;
    [SerializeField] ScoreHandler scoreHandler;

    private void Start()
    {
        healthbar = GetComponentInChildren<FloatingHealthbar>();
        scoreHandler = GameObject.FindWithTag("Canvas").GetComponentInChildren<ScoreHandler>();
        soundPlayer = GameObject.FindWithTag("SoundPlayer");
        spriteSpawner = GameObject.FindWithTag("SpriteSpawner");
        animator = GetComponent<Animator>();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (healthbar != null)
        {
            healthbar.UpdateHealth(health, maxHealth);
        }
        if (health <= 0)
        {
            Die();
        }else if (animator != null)
        {
            animator.SetTrigger("DamageEnemy");
        }
    }

    public void RepairDamage(int repairAmount)
    {
        health += repairAmount;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
    private void Die()
    {
        Transform deathTransform = transform;
        scoreHandler.UpdateScore(scoreValue);
        if (deathSound != null)
        {
            soundPlayer.GetComponent<SoundPlayerManager>().PlaySound(deathSound);
        }
        if (spriteSpawner != null)
        {
            spriteSpawner.GetComponent<SpriteSpawner>().SpawnPointText(deathTransform, scoreValue);
            spriteSpawner.GetComponent<SpriteSpawner>().SpawnDeathEffect(deathTransform, deathEffect);
        }
        Destroy(gameObject);
    }
}
