using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoBox : MonoBehaviour {

	public SpriteRenderer sr;
	public TextMesh tm;
	// Use this for initialization
	void Start () {
		Hide ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Hide()
	{
		tm.text = "";
		sr.color = new Color (1f, 1f, 1f, 0f);
	}

	public void Show(string s)
	{
		sr.color = new Color (1f, 1f, 1f, 1f);
		tm.text = s;
	}
}
