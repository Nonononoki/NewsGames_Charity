using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmButton : MonoBehaviour {

	public infoBox ib;
	string s;

	// Use this for initialization
	void Start () {
		s = "Farm:  \n" +
			"Base Cost: 100,000. \n" +
			"Maintain Cost: 50,000. \n" +
			"Produces: 400";
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseEnter()
	{
		ib.Show (s);
	}

	void OnMouseExit()
	{
		ib.Hide ();
	}
}
