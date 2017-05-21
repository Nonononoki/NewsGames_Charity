using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardBehaviourScript : MonoBehaviour {

	bool hasObject=false;
	public Transform cube;
	void Start () {

	}

	// Update is called once per frame
	void Update () {




	}

	void OnMouseDown(){
		if (hasObject == false) {
			Instantiate (cube, transform.position, Quaternion.identity);
		}
		hasObject = true;
	}


}
