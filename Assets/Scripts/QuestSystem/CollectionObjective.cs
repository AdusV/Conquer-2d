using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionObjective : QuestObjective
{
    string itemName;
    public CollectionObjective(Quest par_quest, int amount,string par_itemName)
    {
        quest = par_quest;
        amountToFinished = amount;
        itemName = par_itemName;
        EventController.OnItemPickedUp += ItemPickedUp;
    }
    void ItemPickedUp(string pickedUpObjName)
    {
        if(pickedUpObjName == itemName )
        {
            IncreaseAmount(1);
        }
    }
}
