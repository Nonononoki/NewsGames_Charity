using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildButton : MonoBehaviour {

	public GameObject board;
	public GameObject building;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown()
	{
		BoardScript boardScript = (BoardScript)board.GetComponent (typeof(BoardScript));
		boardScript.objectToBuild = building;
	}
}
