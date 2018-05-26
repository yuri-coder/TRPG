using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicForestTile : GameboardTile {


	// Use this for initialization
	void Start () {
        terrainType = TerrainTypes.Forest;
        moveAmount = 2;
        currentUnit = null;
        spriteList = Resources.LoadAll<Sprite>("Sprites/Tiles/BasicForestTile"); //Loads all sprites at the designated filepath into an array
        tileName = "Forest";
        effect = "DEF/RES +20%";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
