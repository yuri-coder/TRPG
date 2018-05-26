using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicFieldTile : GameboardTile {

	// Use this for initialization
	void Start () {
        terrainType = TerrainTypes.Field;
        moveAmount = 1;
        currentUnit = null;
        spriteList = Resources.LoadAll<Sprite>("Sprites/Tiles/BasicFieldTile"); //Loads all sprites at the designated filepath into an array
        tileName = "Field";
        effect = "";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
