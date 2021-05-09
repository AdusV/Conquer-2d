using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            other.GetComponent<PlayerHealth>().DamageToPlayer(damage);
        }
    }
}
