using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireArrow : Attack {

    public FireArrow()
    {
        physAttack = PhysicalAttackType.Pierce;
        element = ElementalType.Fire;
        physDamage = 10.0;
        magDamage = 5.0;
    }

}
