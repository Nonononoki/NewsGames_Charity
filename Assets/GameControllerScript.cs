using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameControllerScript : MonoBehaviour {
	public int startMoney;
	public int income;
	int money;
	int round;
	// Use this for initialization

	void Start () {
		money = startMoney;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) 
		{
			NextRound ();
		}
	}

	bool SpendMoney(int amount){
		if (money >= amount) {
			money -= amount;
			return true;
		} else {
		
			return false;
		}
	}

		public void NextRound()
		{
			round++;
			money+=income;
		Debug.Log (money);
		}
}
