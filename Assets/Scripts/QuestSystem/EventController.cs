using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{
    public static event Action<string> OnItemPickedUp;
    public static void ItemPickedUp (string nameOfObject)
        {
        OnItemPickedUp?.Invoke(nameOfObject);
        }
}
