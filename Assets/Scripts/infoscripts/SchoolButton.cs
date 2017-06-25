using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolButton : MonoBehaviour {

	public infoBox ib;
	string s;

	// Use this for initialization
	void Start () {
		s = "School:  \n" +
			"Base Cost: 200,000. \n" +
			"Maintain Cost: 50,000. \n" +
			"Raises Education level by 200.";
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
