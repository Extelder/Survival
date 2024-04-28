using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour, IPickuptable
{
    [field: SerializeField] public Item Item { get; private set; }

    public static event Action<PickupItem> ItemPickuped;
    
    public void Pickup()
    {
        ItemPickuped?.Invoke(this);
        Destroy(gameObject);
    }
}
