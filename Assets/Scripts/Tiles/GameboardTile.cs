using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameboardTile : MonoBehaviour {

    public TerrainTypes terrainType = TerrainTypes.Field; //The generic TerrainType of this tile
    public int moveAmount = 1; //Amount of movement required to enter this tile 
    public Unit currentUnit = null; //The Unit currently occupying this tile, if any
    public Sprite[] spriteList; //List of sprites associated with the tile, indexed by Chapter/Stage theme
    public string tileName = ""; //The name of the tile to be displayed to the user
    public string effect = ""; //A description of the effect that the tile has on a unit to be displayed to the user
    public bool softObstacle = false; //True if units can't enter unless they have special movement.
    public bool hardObstacle = false; //True if no unit can enter, regardless of special movement. (Walls, Gameboard border, etc.)


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
