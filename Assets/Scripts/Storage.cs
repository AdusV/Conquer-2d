using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Storage : MonoBehaviour
{
    public List<StorageSlot> storageList;
    public int maxCapacity = -1;
    
    // Start is called before the first frame update
    void Start()
    {
        storageList = new List<StorageSlot>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(storageList.FirstOrDefault()?.Amount.ToString() ?? "0");
    }

    public void AddItem(string itemId, int amount = 1)
    {
        var slot = storageList.FirstOrDefault(x => x.ItemId == itemId && x.Amount < maxCapacity);
        if (slot == null)
        {
            slot = new StorageSlot(itemId, amount);
            storageList.Add(slot);
        }
        else
        {
            slot.Amount += amount;
        }
    }
}