using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Inventory/Item", order = 1)]
public class Item : ScriptableObject
{
   [field: SerializeField] public int Id { get; set; }
   [field: SerializeField] public int Name { get; set; }
   [field: SerializeField] public int Amount { get; set; }
   [field: SerializeField] public int MaxAmount { get; set; }
   [field: SerializeField] public Sprite Icon { get; set; }
   [field: SerializeField] public string Description { get; set; }
}
