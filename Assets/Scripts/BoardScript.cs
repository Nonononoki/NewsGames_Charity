using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour {

	public int width;
	public int height;
	public GameObject normalfield;
	public GameObject objectToBuild;

	// Use this for initialization
	void Start () {
		float posX = 0;
		float posY = 0;
		for (int i=0; i<width;i++)
		{
			posX = 0;
			for (int j = 0; j < width; j++) {
				Instantiate (normalfield, new Vector3 (posX,posY,0), Quaternion.identity);
				posX+=normalfield.GetComponent<SpriteRenderer>().bounds.size.x;
			}
			posY+=normalfield.GetComponent<SpriteRenderer>().bounds.size.y;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
