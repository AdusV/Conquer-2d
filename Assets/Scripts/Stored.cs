using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stored : MonoBehaviour
{
    public int stackSize = 62;
    private bool isStored = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isStored) return;
        
        isStored = true;
        var storage = collision.GetComponent<Storage>();
        storage.AddItem(gameObject.tag);
        gameObject.SetActive(false);
        Destroy(this.gameObject);
    }
}
