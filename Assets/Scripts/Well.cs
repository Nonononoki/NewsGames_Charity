using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Well : Building {

	public int Cost { private set; get; }
	public int Maintainance { private set; get; }
	public int Produce { private set; get; }

	public static List<Well> _wellList;

	// Use this for initialization
	void Awake () {

		Cost = 50000;
		Maintainance = 10000;
		Produce = 200;

		if (_wellList == null)
			_wellList = new List<Well> ();

		_wellList.Add (this);

		//subtract money
		GameObject resources = GameObject.Find ("Resources");
		Resources r = resources.GetComponent<Resources> ();
		r.Money -= Cost;

		Debug.Log ("Well");
	}

	public static List<Well> getList()
	{
		if (_wellList == null) {
			_wellList = new List<Well> ();
		}
		return _wellList;
	}
}
