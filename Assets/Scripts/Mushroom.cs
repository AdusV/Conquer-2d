using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    [SerializeField] int points;

    void OnDestroy() {
        
        PlayerStats.Instance.AddPoints(points);
        PlayerStats.Instance.questStorage.GetComponent<PickUpMushrooms>().PickupEvent();
        EventController.ItemPickedUp("mushroom");
    }
}
