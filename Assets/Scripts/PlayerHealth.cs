using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int healthPoints;
    private void Start()
    {
        InvokeRepeating("Healthe", 0, 1);
    }
    void Healthe()
    {
        PlayerStats.Instance.UpdateHealthTime(healthPoints);
       // Debug.Log(PlayerStats.Instance.HealthTime); 
    }
    public void StartHealth()
    {
        CancelInvoke();
        InvokeRepeating("Healthe", 0, 1);
    }
    public void StopHealth()
    {
        CancelInvoke("Healthe");
    }
    public void DamageToPlayer(int dmg)
    {
        healthPoints -= dmg;

    }
}
