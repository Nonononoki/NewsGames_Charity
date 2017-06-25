using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : Building {

	public float Cost;
	public float baseMaintainance;
	public float Maintainance;
	public float Produce;


	public static List<School> _schoolList;

	// Use this for initialization
	void Start() {
		Maintainance = baseMaintainance * (0.5f + 0.5f*distance);

		if (_schoolList == null)
			_schoolList = new List<School> ();

		_schoolList.Add (this);

		//subtract money
		GameObject resources = GameObject.Find ("Resources");
		Resources r = resources.GetComponent<Resources> ();
		r.Money -= (int)Cost;

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
