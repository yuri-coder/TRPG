using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializableCharacter {

    public int level, health, attack, magic, defence, resistance;
    public int movement;
    public double accuracy; //Base is 100;
    public List<double> elementResists;

    public SerializableCharacter()
    {

    }

    public SerializableCharacter(Character character)
    {

    }

}
