using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInfo : MonoBehaviour {

	public infoBox ib;
	string s;

	// Use this for initialization
	void Start () {
		s = "Food:  \n" +
			"Food is consumed every \n" +
			"round. The consumed amount \n" +
			"equals the population.";
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
