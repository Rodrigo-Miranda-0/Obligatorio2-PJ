using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        DamageHandler damageHandler = other.GetComponent<DamageHandler>();
        if (damageHandler != null)
        {
            damageHandler.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
