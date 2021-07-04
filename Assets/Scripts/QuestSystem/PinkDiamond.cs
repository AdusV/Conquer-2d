using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkDiamond : MonoBehaviour
{
    [SerializeField] int points;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats.Instance.AddPoints(points);
        Destroy(this.gameObject);
    }
    
    void OnDestroy() {
        
        PlayerStats.Instance.AddPoints(points);
        PlayerStats.Instance.questStorage.GetComponent<PinkDiamondQuest>().PickupEvent();
        EventController.ItemPickedUp("mushroom");
    }
}
