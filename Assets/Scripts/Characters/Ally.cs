using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ally : Unit {

    //Equippables
    public Weapon weapon;
    public Equipment headEquipment;
    public Equipment chestEquipment;
    public Equipment legEquipment;
    public Consumable consumable1;
    public Consumable consumable2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Called when equipping any piece of equipment.
    public void EquipItem(Equipment equipment)
    {
        if (equipment == null)
            return;

        switch (equipment.slot)
        {
            case EquipmentSlots.Weapon:
                UnequipItem(weapon);
                break;
            case EquipmentSlots.Head:
                UnequipItem(headEquipment);
                break;
            case EquipmentSlots.Chest:
                UnequipItem(chestEquipment);
                break;
            case EquipmentSlots.Legs:
                UnequipItem(legEquipment);
                break;
            default:
                print("Applicable equipment slot not found!");
                break;
        }

        foreach (Attack primary in equipment.primaryAttacks)
        {
            primaryAttacks.Add(primary);
        }

        foreach (Attack counter in equipment.counterAttacks)
        {
            counterAttacks.Add(counter);
        }

        health += equipment.health;
        attack += equipment.atk;
        defence += equipment.def;
        magic += equipment.mag;
        resistance += equipment.res;
        movement += equipment.mov;
        accuracy += equipment.accuracy;
        foreach (KeyValuePair<ElementalTypes, double> element in equipment.elementalResists)
        {
            //For added security, in the case that a new type of element resist is added? Probably unnecessary 
            /*if(!elementResists.ContainsKey(element.Key))
            {
                elementResists.Add(element.Key, element.Value);
            }
            else
            {
                elementResists[element.Key] += element.Value;
            }*/
            elementResists[element.Key] += element.Value;
        }
    }

    public void EquipItem(Consumable cons)
    {
        if (cons == null)
            return;

    }

    //Removes linked primary/counter attacks from the equipment, resets stats gained from the equipment, and then sets the equipment slot to null
    public void UnequipItem(Equipment equipment)
    {
        if (equipment == null)
            return;

        foreach (Attack primary in equipment.primaryAttacks)
        {
            primaryAttacks.Remove(primary);
        }

        foreach (Attack counter in equipment.counterAttacks)
        {
            counterAttacks.Remove(counter);
        }

        health -= equipment.health;
        attack -= equipment.atk;
        defence -= equipment.def;
        magic -= equipment.mag;
        resistance -= equipment.res;
        movement -= equipment.mov;
        accuracy -= equipment.accuracy;
        foreach (KeyValuePair<ElementalTypes, double> element in equipment.elementalResists)
        {
            elementResists[element.Key] -= element.Value;
        }

        if (equipment == weapon)
            weapon = null;
        else if (equipment == headEquipment)
            headEquipment = null;
        else if (equipment == chestEquipment)
            chestEquipment = null;
        else if (equipment == legEquipment)
            legEquipment = null;
        else
            print("Item to unequip didn't match any currently equipped items!");
    }

}
