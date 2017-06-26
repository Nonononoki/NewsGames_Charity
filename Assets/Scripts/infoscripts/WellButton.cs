using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellButton : MonoBehaviour {

	public infoBox ib;
	string s;

	// Use this for initialization
	void Start () {
		s = "Well:  \n" +
			"Base Cost: 50,000. \n" +
			"Base Maintain Cost: 10,000. \n" +
			"Base Production: 300 Water.";
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
