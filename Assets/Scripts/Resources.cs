using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour {

	public int Population;
	public int Money;
	public int Food;
	public int Water;
	public int Education;

	public float PopulationIncrease = 1.1f; //increase in percentage
	public int MoneyIncrease = 400000;
	public int FoodIncrease = 0;
	public int WaterIncrease = 0;
	public int EducationIncrease = 0;

	public float PopulationDecrease = 0f;
	public int MoneyDecrease = 0;
	public int FoodDecrease = 0;
	public int WaterDecrease = 0;
	public int EducationDecrease;

	// Use this for initialization
	void Start () {
		//set default resources
		Population = 1000;
		Money = 400000;
		Water = 0;
		Food = 0;
		Education = 0;
	}

	private void Reset()
	{
		MoneyIncrease = 0;
		FoodIncrease = 0;
		WaterIncrease = 0;
		EducationIncrease = 0;

		MoneyDecrease = 0;
		FoodDecrease = 0;
		WaterDecrease = 0;
		EducationDecrease = 0;
	}

	void Apply() //Apply changes
	{
		Population = Population * (PopulationIncrease - PopulationDecrease);

		//decrease

		Money += MoneyIncrease - MoneyDecrease;
		Food += FoodDecrease - FoodDecrease;
		Water += WaterIncrease - WaterDecrease;
		Education += EducationIncrease - EducationDecrease;

		Reset ();
	}
}
