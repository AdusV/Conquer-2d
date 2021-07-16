using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stored : MonoBehaviour
{
    public int stackSize = 62;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // todo: problem z kolizją miecza
        Debug.Log(collision.name);
        var storage = collision.GetComponent<Storage>();
        storage.AddItem(gameObject.tag);
    }
}
