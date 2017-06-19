using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildButton : MonoBehaviour {

	public GameObject board;
	public GameObject building;
	AudioSource source;
	public AudioClip click;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown()
	{
		BoardScript boardScript = (BoardScript)board.GetComponent (typeof(BoardScript));
		boardScript.objectToBuild = building;
		source.PlayOneShot (click);
	}
}
