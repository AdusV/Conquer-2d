using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    [SerializeField] int points;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats.Instance.AddPoints(points);
        EventController.ItemPickedUp("cactus");
        Destroy(this.gameObject);
    }
    
    void OnDestroy() {
        
        PlayerStats.Instance.AddPoints(points);
        PlayerStats.Instance.questStorage.GetComponent<CactusQuest1>().PickupEvent();
        EventController.ItemPickedUp("mushroom");
    }
}
