using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item {

    public string itemName; //Name of the item
    public string description; //Flavor text description of the item
    public int itemID; //Unique item ID of the item.  Consumable = 001~099, Weapon = 101~199, Armor = 201~299, Material = 301~399
    public int value; //GP/Money value of the item

    public string imagePath; //String path to the image file

}
