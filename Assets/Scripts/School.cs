using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : Building {

	public int Cost { private set; get; }
	public int Maintainance { private set; get; }
	public int Produce { private set; get; }


	public static List<School> _schoolList;

	// Use this for initialization
	void Awake () {

		Produce = 200;
		Cost = 200000;
		Maintainance = 50000;

		if (_schoolList == null)
			_schoolList = new List<School> ();

		_schoolList.Add (this);

		//subtract money
		GameObject resources = GameObject.Find ("Resources");
		Resources r = resources.GetComponent<Resources> ();
		r.Money -= Cost;

		Debug.Log ("School");
	}

	public static List<School> getList()
	{
		if (_schoolList == null) {
			_schoolList = new List<School> ();
		}

		return _schoolList;
	}
}
