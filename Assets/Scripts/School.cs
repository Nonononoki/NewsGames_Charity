using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : MonoBehaviour {

	public int Cost = 200000;
	public int Maintainance = 50000;
	public int Produce = 200;

	public static List<School> _schoolList;

	// Use this for initialization
	void Awake () {
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
