using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    [field: SerializeField] public int SerialNumber { get; set; }
    [field: SerializeField] public Item Item { get; set; }

    public event Action CurrentDataUpdated;

    public void ChangeSlotValues(PickupItem pickupItem)
    {
        Item = pickupItem.Item;
        CurrentDataUpdated?.Invoke();
    }

    public bool GetMaxAmountRiched() => Item.Amount == Item.MaxAmount;

    public bool CheckMaxAmount(Item nextItem)
    {
        return Item.Amount + nextItem.Amount == Item.MaxAmount;
    }

    public bool CheckOverMaxAmount(Item nextItem)
    {
        return Item.Amount + nextItem.Amount > Item.MaxAmount;
    }
}