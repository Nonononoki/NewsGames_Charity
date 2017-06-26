using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bigInfoBox : MonoBehaviour {

	public SpriteRenderer sr;
	public TextMesh tm;
	public bool reset;

	private BoxCollider2D col;
	AudioSource source;
	public AudioClip clip;
	private string s;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
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
			"The further away a building from the nearest village is, the \n" +
			"higher is its maintainance cost.\n" +
			"You will lose if you cannot support the villages anymore. \n"
			;

		Show (s);
		source.clip = clip;
		source.volume = 0.7f;
		source.loop = true;
		source.Play();
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

	public void Show()
	{
		sr.color = new Color (1f, 1f, 1f, 1f);
		tm.text = s;
		col.enabled = true;

	}


	public void OnMouseDown()
	{
		if (!reset) {
			Hide ();

		}
		else
			Reset ();
	}

	public void Reset()
	{
		source.Stop();
		source.Play();
		Scene loadedLevel = SceneManager.GetActiveScene ();
		SceneManager.LoadScene (loadedLevel.name);

		if (Farm._farmList != null)
			Farm._farmList.Clear ();

		if (School._schoolList != null)
			School._schoolList.Clear ();


		if (Well._wellList != null)
			Well._wellList.Clear ();
	}


}
