using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : MonoBehaviour {

	public int Cost = 100000;
	public int Maintainance = 10000;
	public int Produce = 400;

	public static List<Farm> _farmList;

	// Use this for initialization
	void Start () {
		if (_farmList = null)
			_farmList = new List<Farm> ();

		_farmList.Add (this);
	}

	public static List<Farm> getList()
	{
		return _farmList;
	}
}
