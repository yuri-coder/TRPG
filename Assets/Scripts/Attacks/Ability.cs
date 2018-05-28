using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability {

    public string abilityName; //Name of the ability
    public string description; //Flavor text description of the ability
    //public int attackID; //Unique ID of the attack

    public abstract void Use(Unit user, Unit target);

    public abstract void Use(Unit user);

}
