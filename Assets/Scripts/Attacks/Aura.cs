using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Aura : Ability{

    public int turns; //The remaining number of turns the aura remains active

    public override void Use(Unit user, Unit target)
    {
        Use(user);
    }

    

}
