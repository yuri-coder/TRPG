using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMountainTile : GameboardTile {

	// Use this for initialization
	void Start () {
        terrainType = TerrainTypes.Mountain;
        moveAmount = 3;
        currentUnit = null;
        spriteList = Resources.LoadAll<Sprite>("Sprites/Tiles/BasicMountainTile"); //Loads all sprites at the designated filepath into an array
        tileName = "Mountain";
        effect = "DEF/RES +30%";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
