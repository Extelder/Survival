using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InventoryItem))]
public class InventoryItemUI : MonoBehaviour
{
    [SerializeField] private Text _amountText;
    [SerializeField] private Image _iconImage;
    [SerializeField] private Text _nameText;
    [SerializeField] private Text _descriptionText;
    private InventoryItem _inventoryItem;

    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    public void UpdateUIWithData()
    {
        _amountText.text = _inventoryItem.Item.Amount.ToString();
        _iconImage.sprite = _inventoryItem.Item.Icon;
    }
}