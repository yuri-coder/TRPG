using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Unit {

    public DropTable dropTable; //The drop table of this enemy

    //Sub/Hidden Stats
    public int baseExp; //The base experience an enemy awards on being defeated

    //Attacks
    public List<Ability> potentialAttacks; //List of all attacks an enemy could potentially have, but not necessarily what they can use (based on their level)

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
