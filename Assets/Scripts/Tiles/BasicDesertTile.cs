using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDesertTile : GameboardTile {

	// Use this for initialization
	void Start () {
        terrainType = TerrainTypes.Desert;
        moveAmount = 2;
        currentUnit = null;
        spriteList = Resources.LoadAll<Sprite>("Sprites/Tiles/BasicDesertTile"); //Loads all sprites at the designated filepath into an array
        tileName = "Desert";
        effect = "DEF/RES -20%";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
