using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    [SerializeField] int hp;
    public void DamageToEnemyManager(int dmg)
    {
        hp -= dmg;
        if (hp<=0)
        {
            Destroy(this.gameObject);
        }
    }
}
