using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public enum ItemType { 
        Sword;
        HealthPotion;
        ManaPotion;
        Coin;
        MedKit;
    }
    public ItemType itemtype;
    public int amount;
}
