using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour {

	public int Population;
	public int Money;
	public int Food;
	public int Water;

	public float PopulationIncrease; //increase in percentage
	public int MoneyIncrease;
	public int FoodIncrease;
	public int WaterIncrease;

	// Use this for initialization
	void Start () {
		//set default resources
		Population = 1000;
		Money = 400000;
		Water = 0;
		Food = 0;

		PopulationIncrease = 1.1f; //10% increase in 4 years

		MoneyIncrease = 0;
		FoodIncrease = 0;
		WaterIncrease = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void Reset()
	{
		MoneyIncrease = 0;
		FoodIncrease = 0;
		WaterIncrease = 0;
	}
}
