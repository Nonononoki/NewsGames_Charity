using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Well : MonoBehaviour {

	public int Cost = 50000;
	public int Maintainance = 10000;
	public int Produce = 200;

	public static List<Well> _wellList;

	// Use this for initialization
	void Start () {
		if (_wellList == null)
			_wellList = new List<Well> ();

		_wellList.Add (this);
	}

	public static List<Well> getList()
	{
		if (_wellList == null) {
			_wellList = new List<Well> ();
		}
		return _wellList;
	}
}
