using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmButton : MonoBehaviour {

	public infoBox ib;
	string s;

	// Use this for initialization
	void Start () {
		s = "Farm:  \n" +
			"Base Cost: 75,000. \n" +
			"Base Maintain Cost: 30,000. \n" +
			"Base Production: 300 Food.";
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
