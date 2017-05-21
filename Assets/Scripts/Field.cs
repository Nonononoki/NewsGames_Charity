using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour {

	bool hasObject=false;
	public Transform cube;
	void Start () {

	}

	// Update is called once per frame
	void Update () {




	}

	void OnMouseDown(){
		if (hasObject == false) {
			Instantiate (cube, new Vector3(transform.position.x, transform.position.y,-10), Quaternion.identity);
		}
		hasObject = true;
	}


}