using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerPlayer : MonoBehaviour
{
    public int health = 100;
    public int maxHealth = 100;
    private int damageByCollision;
    public AudioClip deathSound;
    public GameObject deathEffect;
    private GameObject soundPlayer;
    private GameObject spriteSpawner;
    private Animator animator;
    private GameObject levelManager;
    [SerializeField] ScoreHandler scoreHandler;

    private void Start()
    {
        scoreHandler = GameObject.FindWithTag("Canvas").GetComponentInChildren<ScoreHandler>();
        soundPlayer = GameObject.FindWithTag("SoundPlayer");
        spriteSpawner = GameObject.FindWithTag("SpriteSpawner");
        levelManager = GameObject.FindWithTag("LevelManager");
        animator = GetComponent<Animator>();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }else if (animator != null)
        {
            animator.SetTrigger("DamagePlayer");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        damageByCollision = other.GetComponent<DamageHandler>().collisionDamage;
        TakeDamage(damageByCollision);
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
        if (deathSound != null)
        {
            soundPlayer.GetComponent<SoundPlayerManager>().PlaySound(deathSound);
        }
        if (spriteSpawner != null)
        {
            spriteSpawner.GetComponent<SpriteSpawner>().SpawnDeathEffect(deathTransform, deathEffect);
        }
        levelManager.GetComponent<GameOverHandler>().GameOver();
        gameObject.SetActive(false);
    }
}
