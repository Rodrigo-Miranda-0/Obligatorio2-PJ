using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDamage : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        DamageHandlerPlayer damageHandler = other.GetComponent<DamageHandlerPlayer>();
        if (damageHandler != null)
        {
            damageHandler.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
