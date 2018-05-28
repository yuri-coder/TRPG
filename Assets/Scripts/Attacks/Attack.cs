using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack : Ability {

    public int attackID; //Unique ID of the attack
    public ElementalTypes elementType; //Type of attack
    public bool isPhysical; //True if physical, false if magical
    public double accuracy; //Given as whole % value (10 as opposed to 0.1)

    public override void Use(Unit user)
    {
        return;
    }


}

