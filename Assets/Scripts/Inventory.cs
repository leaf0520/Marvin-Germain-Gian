using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Inventory 
{
    private List<Item> ItemList;
    public Inventory()
    {
        itemList = new List<Item>();
        AddItem(new Item { itemType = Item.ItemType.Sword, amount = 1 }); 
        
    }
    public void AddItem(Item item) {
        itemList.Add(item); 
    }
    }
}
