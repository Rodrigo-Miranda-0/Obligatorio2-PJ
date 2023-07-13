using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairKitScript : MonoBehaviour
{
    [SerializeField] private int repairAmount = 50;
    private void OnTriggerEnter2D(Collider2D other)
    {
        DamageHandlerPlayer damageHandler = other.GetComponent<DamageHandlerPlayer>();
        if (damageHandler != null)
        {
            damageHandler.RepairDamage(repairAmount);
        }

        Destroy(gameObject);
    }
}
