using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyInfo : MonoBehaviour {

	public infoBox ib;
	string s;

	// Use this for initialization
	void Start () {
		s = "Money:  \n" +
			"Needed to build/maintain. \n" +
			"You start with 400,000. \n" +
			"You get 400,000 each round.";
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
