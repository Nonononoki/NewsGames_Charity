using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour {

	public int width;
	public int height;
	public GameObject normalfield;
	public GameObject objectToBuild;
	public int villageAmount;
	GameObject[,] fields;
	public GameObject village;

	// Use this for initialization
	void Start () {
		fields = new GameObject[width,height];
		float posX = 0;
		float posY = 0;
		for (int i=0; i<width;i++)
		{
			posX = 0;
			for (int j = 0; j < width; j++) {
				GameObject field = Instantiate (normalfield, new Vector3 (posX,posY,0), Quaternion.identity);
				field.GetComponent<Field>().position = new Vector2 (posX, posY);
				fields [i,j] = field;
				posX+=normalfield.GetComponent<SpriteRenderer>().bounds.size.x;
			}
			posY+=normalfield.GetComponent<SpriteRenderer>().bounds.size.y;
		}

		CreateVillages ();
	}

	void CreateVillages(){
		for (int i = 0; i < villageAmount; i++) {
			int x = Random.Range (0, width - 1);
			int y = Random.Range (0, height - 1);

			Field fieldScript = fields [x, y].GetComponent<Field> ();

			if (!fieldScript.hasObject) {
				fieldScript.Build (village);
			} else
				i--;
		}
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
