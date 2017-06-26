using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoButton : MonoBehaviour {

	public bigInfoBox ib;
	string s;

	// Use this for initialization
	void Start () {
		s = 
			"Sustain the life of several villages in Africa. \n" +
			"Click on the icons on the top right to build. \n" +
			"Farms produce food, wells produce water and schools raise the \n" +
			"education level. \n" +
			"Building on Green Fields increases the Base Costs, but\n" +
			"Productivity is increased. The opposite applies for Red Fields. \n" +
			"Schools are not affected by the color of the field. \n" +
			"You have to import food and water if you cannot provide them. \n" +
			"You need to raise the education level to the population level \n" +
			"in order to win. \n" + 
			"The further away a building from the nearest village is, the \n" +
			"higher is its maintainance cost.\n" +
			"You will lose if you cannot support the villages anymore. \n"
			;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*
	void OnMouseEnter()
	{
		ib.Show (s);
	}

	void OnMouseExit()
	{
		ib.Hide ();
	}
	*/

	void OnMouseDown()
	{
		ib.Show (s);
	}
}
