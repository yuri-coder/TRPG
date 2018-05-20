using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack {

    public string attackName; //Name of the attack
    public string description; //Flavor text description of the attack
    public int attackID; //Unique ID of the attack
    public ElementalTypes elementType; //Type of attack
    public bool isPhysical; //True if physical, false if magical
    public double accuracy; //Given as whole % value (10 as opposed to 0.1)

    //Called when using an attack
    public abstract void UseAttack(Character user, Character target);


}

