using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour {

	public bool hasObject=false;
	GameObject building;
	BoardScript boardScript;
	GameObject resources;
	public Vector2 position;
	public float multiplier;



	void Start () {
		GameObject board = GameObject.Find ("Board");
		resources = GameObject.Find ("Resources");
		boardScript =(BoardScript) board.GetComponent (typeof(BoardScript));
	}

	// Update is called once per frame
	void Update () {




	}

	public void Build(GameObject pBuilding){
		building =Instantiate (pBuilding, new Vector3(transform.position.x, transform.position.y,-10), Quaternion.identity);

		var script=building.GetComponent<Building>();
		script.multiplier = multiplier;
	}

	void OnMouseDown(){
		Resources r = resources.GetComponent<Resources> ();



		//can only build if you have some money
		if (hasObject == false && boardScript.objectToBuild!=null && r.Money > 0) {
			
			Build (boardScript.objectToBuild);

		}



		r.Apply ();
	}


}