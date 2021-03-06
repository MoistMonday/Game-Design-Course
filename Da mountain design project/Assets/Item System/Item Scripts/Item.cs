﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [HideInInspector] public int itemID;

    private void OnTriggerEnter(Collider other)
    {
        GameEvents.gameEvents.ItemPickUpTriggerEnter(itemID);
    }
}
