using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour {

    public static BattleManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Returns an Item String + Amount pair Drop from a shared drop roll.
    //@Param: Dictionary<Drop, int> drops = { (ItemStringName, amountReceived) : weightedChance } ; totalChance = combined weighted drop rate for all items
    public Drop SharedChanceRoll(Dictionary<Drop, int> drops, int totalChance)
    {
        int rng = Random.Range(0, totalChance);
        foreach (KeyValuePair<Drop, int> slot in drops)
        {
            rng -= slot.Value;
            if (rng < 0)
            {
                return slot.Key;
            }
        }
        return new Drop();
    }

    public Drop SharedChanceRoll(Dictionary<Drop, int> drops)
    {
        int totalChance = 0;
        foreach (KeyValuePair<Drop, int> drop in drops)
        {
            totalChance += drop.Value;
        }
        return SharedChanceRoll(drops, totalChance);
    }

}
