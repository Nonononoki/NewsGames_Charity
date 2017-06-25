using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EducationInfo : MonoBehaviour {

	public infoBox ib;
	string s;

	// Use this for initialization
	void Start () {
		s = "Education:  \n" +
			"Needed to win the game! \n" +
			"Schools are needed for \n" +
			"increasing the value.";
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
