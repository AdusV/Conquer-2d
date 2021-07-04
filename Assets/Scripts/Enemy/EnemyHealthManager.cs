using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    [SerializeField] int hp;

    public GameObject Quests;
    
    void Start()
    {

        
    }
    
    public void DamageToEnemyManager(int dmg)
    {
        hp -= dmg;
        if (hp<=0)
        {
            var quest = Quests.GetComponent<KillBanditQuest>();
            quest.KillBanditEvent();
            
            Destroy(this.gameObject);
        }
    }
}
