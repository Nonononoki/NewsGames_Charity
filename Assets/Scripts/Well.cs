using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Well : Building {

	public float baseCost;
	public float Cost{ private set; get; }
	public float baseMaintainance;
	public float Maintainance { private set; get; }
	public float baseProduce;
	public float Produce { private set; get; }

	public static List<Well> _wellList;

	// Use this for initialization
	void Start() {


		Cost = baseCost*multiplier*multiplier;
		Maintainance = baseMaintainance*distance;

		Produce = baseProduce * multiplier;

		if (_wellList == null)
			_wellList = new List<Well> ();

		_wellList.Add (this);

		//subtract money
		GameObject resources = GameObject.Find ("Resources");
		Resources r = resources.GetComponent<Resources> ();
		r.Money -=(int) Cost;

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
