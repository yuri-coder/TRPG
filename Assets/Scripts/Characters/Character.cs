using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //Main Stats
    public int level, health, attack, magic, defence, resistance;
    public int movement;
    public double accuracy; //Base is 100;
    public Dictionary<ElementalTypes, double> elementResists;

    //Equippables
    public Weapon weapon;
    public Equipment headEquipment;
    public Equipment chestEquipment;
    public Equipment legEquipment;

    //Attacks
    public List<Attack> primaryAttacks; //Attacks that can be used to initiate combat
    public List<Attack> counterAttacks; //Attacks that can be used during CounterCombat

    //Runs at the start of a combat phase, before any attacks are used.
    public abstract void PreCombat();

    //When attacked, runs after the opponent has used their attack
    public abstract void CounterCombat();

    //Runs at the end of a combat phase, after regular attacks and counter attacks have been resolved
    public abstract void PostCombat();

    //Runs at the start of every turn, regardless of friendly or enemy turn. 
    //Events that occur in StartOfTurn should check if it depends on if it's the ally or enemy turn.
    public abstract void StartOfTurn();

    //Runs at the end of every turn, regardless of friendly or enemy turn. 
    //Events that occur in EndOfTurn should check if it depends on if it's the ally or enemy turn.
    public abstract void EndOfTurn();
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