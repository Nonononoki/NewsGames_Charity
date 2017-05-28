using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour {

	bool hasObject=false;
	GameObject building;
	BoardScript boardScript;
	void Start () {
		GameObject board = GameObject.Find ("Board");
		boardScript =(BoardScript) board.GetComponent (typeof(BoardScript));
	}

	// Update is called once per frame
	void Update () {




	}

	void OnMouseDown(){
		building = boardScript.objectToBuild;
		if (hasObject == false && building!=null) {
			
			Instantiate (building, new Vector3(transform.position.x, transform.position.y,-10), Quaternion.identity);

			Debug.Log (building.name);
		}
		hasObject = true;
	}


}