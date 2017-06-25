using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bigInfoBox : MonoBehaviour {

	public SpriteRenderer sr;
	public TextMesh tm;
	public bool reset;

	private BoxCollider2D col;

	private string s;

	// Use this for initialization
	void Start () {
		reset = false;
		col = gameObject.GetComponent<BoxCollider2D> ();

		s = 
			"Sustain the life of several villages in Africa. \n" +
			"Click on the icons on the top right to build. \n" +
			"Farms produce food, wells produce water and schools raise the \n" +
			"education level. \n" +
			"Building on Green Fields increases the Base Costs, but\n" +
			"Productivity is increased. The opposite applies for Red Fields. \n" +
			"Schools are not affected by the color of the field. \n" +
			"You have to import food and water if you cannot provide them. \n" +
			"You need to raise the education level to the population level \n" +
			"in order to win. \n" + 
			"You will lose if you cannot support the villages anymore. \n"
			;

		Show (s);
	}

	// Update is called once per frame
	void Update () {

	}

	public void Hide()
	{
		tm.text = "";
		sr.color = new Color (1f, 1f, 1f, 0f);
		col.enabled = false;
	}

	public void Show(string s)
	{
		sr.color = new Color (1f, 1f, 1f, 1f);
		tm.text = s;
		col.enabled = true;
	}


	public void OnMouseDown()
	{
		if (!reset)
			Hide ();
		else
			Reset ();
	}

	public void Reset()
	{
		Scene loadedLevel = SceneManager.GetActiveScene ();
		SceneManager.LoadScene (loadedLevel.name);
	}


}
