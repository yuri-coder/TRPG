using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializableUnit {

    public int level, health, attack, magic, defence, resistance;
    public int movement;
    public double accuracy; //Base is 100;
    public List<double> elementResists;

    public SerializableUnit()
    {

    }

    public SerializableUnit(Unit character)
    {

    }

}
