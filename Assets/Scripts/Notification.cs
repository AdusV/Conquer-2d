﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notification : MonoBehaviour
{
    private void Start()
    {
        Destroy(this.gameObject, 6);
    }
}
