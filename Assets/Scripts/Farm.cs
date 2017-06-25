using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : Building {

	public float baseCost;
	public float Cost{ private set; get; }
	public float baseMaintainance;
	public float Maintainance { private set; get; }
	public float baseProduce;
	public float Produce { private set; get; }


	public static List<Farm> _farmList;

	// Use this for initialization
	void Start() {


		Cost = baseCost * multiplier*multiplier;

		Maintainance = baseMaintainance * (0.5f + 0.5f*distance);

		Produce = baseProduce * multiplier;

		if (_farmList == null)
			_farmList = new List<Farm> ();

		_farmList.Add (this);

		//subtract money
		GameObject resources = GameObject.Find ("Resources");
		Resources r = resources.GetComponent<Resources> ();
		r.Money -= (int)Cost;

		Debug.Log ("Farm");
	}

	public static List<Farm> getList()
	{
		if (_farmList == null) {
			_farmList = new List<Farm> ();
		}

		return _farmList;
	}
}
