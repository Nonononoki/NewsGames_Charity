using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour {

	public int width;
	public int height;
	public GameObject normalField;
	public GameObject goodField;
	public GameObject badField;
	public GameObject objectToBuild;
	public int villageAmount;
	GameObject[,] fields;
	public GameObject village;
	public List<Village> villages;

	// Use this for initialization
	void Start () {
		int goods = villageAmount * 2;
		int bads = villageAmount * 2;
		fields = new GameObject[width,height];
		villages = new List<Village>();
		float posX = 0;
		float posY = 0;
		for (int i=0; i<width;i++)
		{
			posX = 0;


			for (int j = 0; j < width; j++) {
				GameObject field = Instantiate (normalField, new Vector3 (posX,posY,0), Quaternion.identity);
				field.GetComponent<Field>().position = new Vector2 (i, j);
				fields [i,j] = field;
				posX+=normalField.GetComponent<SpriteRenderer>().bounds.size.x;
			}
			posY+=normalField.GetComponent<SpriteRenderer>().bounds.size.y;
		}


		for (int i = 0; i < goods; i++) {
			int x = Random.Range (0, width - 1);
			int y = Random.Range (0, height - 1);

			if (fields[x,y].gameObject.tag!="good") {
				Vector3 pos = fields [x, y].gameObject.transform.position;
				Destroy (fields [x, y].gameObject);
				fields[x,y]=Instantiate(goodField, pos, Quaternion.identity);
			} else
				i--;
		}

		for (int i = 0; i < bads; i++) {
			int x = Random.Range (0, width - 1);
			int y = Random.Range (0, height - 1);

			if (fields[x,y].gameObject.tag!="good" && fields[x,y].gameObject.tag!="bad") {
				Vector3 pos = fields [x, y].gameObject.transform.position;
				Destroy (fields [x, y].gameObject);
				fields[x,y]=Instantiate(badField, pos, Quaternion.identity);
			} else
				i--;
		}


		CreateVillages ();
	}

	void CreateVillages(){
		for (int i = 0; i < villageAmount; i++) {
			int x = Random.Range (0, width - 1);
			int y = Random.Range (0, height - 1);

			Field fieldScript = fields [x, y].GetComponent<Field> ();

			if (!fieldScript.hasObject && fields[x,y].gameObject.tag!="good" && fields[x,y].gameObject.tag!="bad") {
				fieldScript.Build (village);

				Debug.Log ("ayyy");
			} else {
				i--;

			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
