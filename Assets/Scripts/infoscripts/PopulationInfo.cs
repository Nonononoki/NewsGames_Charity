using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationInfo : MonoBehaviour {

	public infoBox ib;
	string s;

	// Use this for initialization
	void Start () {
		s = "Population:  \n" +
			"Start with a population of 1000. \n" +
			"Population in increased by \n" +
			"100 each round."
			;
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
