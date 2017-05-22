using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

	public NextRoundButton nrb;

	// Use this for initialization
	void Start () {
		//print Controls

		Debug.Log ("Press F to build Farm");
		Debug.Log ("Press W to build Well");
		Debug.Log ("Press S to build School");
		Debug.Log ("Press I to view Info");
		Debug.Log ("Press Space to go next round");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.F)) 
		{
			//Farm f = new Farm ();
			Farm f = gameObject.AddComponent(typeof(Farm)) as Farm;
			Debug.Log ("Built a farm!");
		}
		if (Input.GetKeyDown (KeyCode.W)) 
		{
			//Well w = new Well ();
			Well w = gameObject.AddComponent(typeof(Well)) as Well;
			Debug.Log ("Built a well!");
		}
		if (Input.GetKeyDown (KeyCode.S)) 
		{
			//School s = new School ();
			School s = gameObject.AddComponent(typeof(School)) as School;
			Debug.Log ("Built a school!");
		}
		if (Input.GetKeyDown (KeyCode.I)) 
		{
			//Display Info
			PrintInfo();
		}
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			nrb.NextRound ();
		}
	}

	void PrintInfo()
	{
		Debug.Log (
			"Pro Runde erhaelt der Spieler 400.000€ um seine Projekte zu realisieren.\n" +
			"Jedes Dorf verbraucht am Ende des Zuges Nahrung und Wasser proportional zur Bevoelkerung.\n" +
			"Jede Runde waechst die Bevoelkerung um 10 Prozent.\n" +
			"Farmen produzieren Nahrung, Brunnen produzieren Wasser \n" + 
			"Wenn der Spieler den Verbrauch nicht decken kann, muss der Spieler fuer die Deckung zahlen\n" +
			"Wenn das Geld auf 0 sinkt, verliert der Spieler.\n" +
			"Die Schule erhoeht jede Runde den Bildungsgrad, ist dieser bei 100% angelangt ist das Spiel gewonnen.\n" +
			"Gebauede besitzen Bebauungs- und Verwaltungskosten.");
	}
}
