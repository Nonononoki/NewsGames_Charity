using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : MonoBehaviour {

	public int Cost = 200000;
	public int Maintainance = 20000;
	public int Produce = 10;

	public static List<School> _schoolList;

	// Use this for initialization
	void Start () {
		if (_schoolList = null)
			_schoolList = new List<School> ();

		_schoolList.Add (this);
	}

	public static List<School> getList()
	{
		return _schoolList;
	}
}
