using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : Item {

    /*
     * Stat Modifications Granted on Equip
     */
    public int health, atk, def, mag, res; 
    public int mov;
    public double accuracy; //Given as whole % value (10 as opposed to 0.1)
    public Dictionary<ElementalTypes, double> elementalResists; //Given as whole % value (10 as opposed to 0.1)

    public EquipmentSlots slot;

    public List<Attack> primaryAttacks;
    public List<Attack> counterAttacks;

}
