﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoButton : MonoBehaviour {

	public infoBox ib;
	string s;

	// Use this for initialization
	void Start () {
		s = "Build buildings to sustain the life \n" +
		"of a village in Africa. \n" +
		"Win: Education >= population. \n" +
		"Lose: Money <= 0 \n" +
		"Red: -Base cost, -Production \n" +
		"Green: +Base cost, +Production \n" +
		"Schools are not affected \n";
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
