using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public void PreCombat()
    {

    }

    public void CounterCombat()
    {

    }

    public void PostCombat()
    {

    }
}

/*public class GameManager
{

    //Keep track of Initiator and Defender
    public void AttackPhase(Character attacker, Character defender, Attack mainAttack)
    {
        attacker.PreCombat();
        defender.PreCombat();
        attacker.UseAttack(mainAttack, defender);
        defender.CounterCombat();
        attacker.PostCombat();
        defender.PostCombat();
    }
}*/

    /*public double atk, def, mag, res;
    public int mov;

    public double pierceResist, crushResist, slashResist;

    public List<double> physResists;  //0 = pierce, 1  = slash, 2 = crush

    public Dictionary<PhysicalAttackType, double> physicalResistances = new Dictionary<PhysicalAttackType, double>()
    {
        {PhysicalAttackType.Crush , 20 },
        {PhysicalAttackType.Pierce, 10 },
        {PhysicalAttackType.Slash, -22 }
    };

    public double fireResist, iceResist, windResist;

    List<Attack> usableAttacks;

    //public double UseAttack(Attack atk, Character target)
    //{
    //    double damage = 0.0;

    //    DealDamage(atk.physDamage, physicalResistances[atk.physAttack]);


    //    return damage;
    //}

    //public double DealDamage(double atkAmt, double defAmt)
    //{
    //    return atkAmt - defAmt;
    //}


    //Game Manager
    public void AttackPhase(Character attacker, Attack usedAttack, Character defender)
    {
        if(usedAttack is SupportAttack)
        {
            //attacker.UseAttack(usedAttack, defender);
            //attacker.AfterCombat(defender);
            //defender.AfterCombat(attacker);
        }
        else
        {
            //attacker.PreCombat(defender);
            //defender.PreCombat(attacker);
            //attacker.UseAttack(usedAttack, defender);
            //attacker.AfterCombat(defender);
            //defender.AfterCombat(attacker);
        }
        //attacker.PreCombat(defender);
        //defender.PreCombat(attacker);
        //attacker.UseAttack(usedAttack, defender);
        //attacker.AfterCombat(defender);
        //defender.AfterCombat(attacker);
        
    }


    //Character
    public void UseAttack(Attack usedAttack, Character defender)
    {

    }

    
    public void AfterCombat()
    {

    }


}

public class Warrior : Character
{
    List<Attack> mainAttacks;
    List<Attack> counterAttacks;
    public void PreCombat(Character defender)
    {

    }

    public void CounterCombat(Character defender)
    {
        foreach (Attack atk in counterAttacks)
        {
            this.UseAttack(atk, defender);
        }
    }

    public void AfterCombat(Character defender)
    {

    }
}

public class Ninja : Character
{
    List<Attack> mainAttacks;
    List<Attack> counterAttacks;

    public void PreCombat(Character defender)
    {
        foreach(Attack atk in counterAttacks)
        {
            this.UseAttack(atk, defender);
        }
    }

    public void CounterCombat(Character defender)
    {

    }

    public void AfterCombat(Character defender)
    {
        foreach (Attack atk in counterAttacks)
        {
            this.UseAttack(atk, defender);
        }
    }
}


/*
 *Attack Phase
 * 1.  Unit attacks 
 * 2.  
 * 
 * Pre-combat
 *    
 * Main combat
 * Post-combat
 * 
 * 
 * 
 * 
 * 
 * 
 */