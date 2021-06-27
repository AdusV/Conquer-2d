using UnityEngine;

public class StorageSlot
{
    public string ItemId { get; }
    public int Amount { get; set; } 
    public int maxCapacity { get; set; } 

    public StorageSlot(string itemId, int amount = 1)
    {
        ItemId = itemId;
        Amount = amount;

        maxCapacity = 64;
    }
}