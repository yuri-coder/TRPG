using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour {

    public Transform watergrassposition;
    public MainGameManager mymanager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.015f, 0, 0);
        watergrassposition.position = new Vector3(watergrassposition.position.x + 0.03f, 0, 0);
        mymanager.PrintSomething("working!");
    }
}
