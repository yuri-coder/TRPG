using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicWaterTile : GameboardTile {

	// Use this for initialization
	void Start () {
        terrainType = TerrainTypes.Water;
        moveAmount = 1;
        currentUnit = null;
        spriteList = Resources.LoadAll<Sprite>("Sprites/Tiles/BasicWaterTile"); //Loads all sprites at the designated filepath into an array
        tileName = "Water";
        effect = "DEF/RES +30%";
        softObstacle = true; //Normal units should not be able to enter tiles that are soft obstacles. Only units with special movements can enter.
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
