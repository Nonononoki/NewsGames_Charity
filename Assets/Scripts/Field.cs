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
	public AudioClip clickSound;
	AudioSource source;

	void Awake(){
		source = GetComponent<AudioSource> ();
		GameObject board = GameObject.Find ("Board");
		boardScript =(BoardScript) board.GetComponent (typeof(BoardScript));
	}

	void Start () {
		
		resources = GameObject.Find ("Resources");


	}

	// Update is called once per frame
	void Update () {




	}

	public void Build(GameObject pBuilding){
		building = Instantiate (pBuilding, new Vector3(transform.position.x, transform.position.y,-10), Quaternion.identity);
		var script=building.GetComponent<Building>();
		script.multiplier = multiplier;
		script.position = this.position;
		hasObject = true;
		if (building.tag == "village") {
			boardScript.villages.Add (building.GetComponent<Village> ());
		} else {
			CalcDistance (script);
		}

	}

	void CalcDistance(Building script){
		int dist = 100000;
		foreach (var village in boardScript.villages) {
			int tempDist = (int)Mathf.Max (Mathf.Abs(script.position.x-village.position.x),Mathf.Abs(script.position.y-village.position.y) );
			if(dist>tempDist){
				dist = tempDist;}
		}	
		script.distance = dist;
	}


	void OnMouseDown(){
		Resources r = resources.GetComponent<Resources> ();
		//can only build if you have some money
		if (hasObject == false && boardScript.objectToBuild!=null && r.Money > 0) {
			
			Build (boardScript.objectToBuild);
			source.PlayOneShot (clickSound);
		}



		r.Apply ();
	}


}