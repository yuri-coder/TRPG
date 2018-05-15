using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack {

    public PhysicalAttackType physAttack;
    public ElementalType element;
    public double physDamage;
    public double magDamage;
	
}

public enum PhysicalAttackType
{
    Pierce,
    Slash,
    Crush
} 

public enum ElementalType
{
    Fire,
    Ice,
    Wind
}