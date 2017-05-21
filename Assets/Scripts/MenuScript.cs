using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

	public NextRoundButton nrb;

	// Use this for initialization
	void Start () {
		//print Controls

		Debug.Log ("Press F to build Farm");
		Debug.Log ("Press W to build Well");
		Debug.Log ("Press S to build School");
		Debug.Log ("Press I to view Info");
		Debug.Log ("Press Space to go next round");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.F)) 
		{
			//Farm f = new Farm ();
			Farm f = gameObject.AddComponent(typeof(Farm)) as Farm;
			Debug.Log ("Built a farm!");
		}
		if (Input.GetKeyDown (KeyCode.W)) 
		{
			//Well w = new Well ();
			Well w = gameObject.AddComponent(typeof(Well)) as Well;
			Debug.Log ("Built a well!");
		}
		if (Input.GetKeyDown (KeyCode.S)) 
		{
			//School s = new School ();
			School s = gameObject.AddComponent(typeof(School)) as School;
			Debug.Log ("Built a school!");
		}
		if (Input.GetKeyDown (KeyCode.I)) 
		{
			//Display Info
		}
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			nrb.NextRound ();
		}
	}
}
