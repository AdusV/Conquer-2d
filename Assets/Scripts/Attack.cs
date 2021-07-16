using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int damage;
    Animator anim;
    Collider2D m_Collider;
    private void Start()
    {
        anim = GetComponent<Animator>();
        m_Collider = GetComponent<Collider2D>();
    }
    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_Collider.enabled = !m_Collider.enabled;
            anim.SetTrigger("attacksword");
           
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy") 
        {
            other.GetComponent<EnemyHealthManager>().DamageToEnemyManager(damage);
            
        }
    }
}
