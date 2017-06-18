using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour {

	public bool hasObject=false;
	GameObject building;
	BoardScript boardScript;
	GameObject resources;
	public Vector2 position;



	void Start () {
		GameObject board = GameObject.Find ("Board");
		resources = GameObject.Find ("Resources");
		boardScript =(BoardScript) board.GetComponent (typeof(BoardScript));
	}

	// Update is called once per frame
	void Update () {




	}

	public void Build(GameObject pBuilding){
		building = pBuilding;
		Instantiate (building, new Vector3(transform.position.x, transform.position.y,-10), Quaternion.identity);
		hasObject = true;
	}

	void OnMouseDown(){
		Resources r = resources.GetComponent<Resources> ();

		building = boardScript.objectToBuild;

		//can only build if you have some money
		if (hasObject == false && building!=null && r.Money > 0) {
			
			Instantiate (building, new Vector3(transform.position.x, transform.position.y,-10), Quaternion.identity);

		}

		hasObject = true;

		r.Apply ();
	}


}