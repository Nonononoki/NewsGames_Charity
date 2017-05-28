using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour {

	public int Population = 1000;
	public int Money = 400000;
	public int Food = 0;
	public int Water = 0;
	public int Education = 0;

	public float PopulationIncrease = 1.1f; //increase in percentage
	public int MoneyIncrease = 400000;
	public int FoodIncrease = 0;
	public int WaterIncrease = 0;
	public int EducationIncrease = 0;

	public float PopulationDecrease = 0f;
	public int MoneyDecrease = 0;
	public int FoodDecrease = 0;
	public int WaterDecrease = 0;
	public int EducationDecrease = 0;

	public GUIText populationText;
	public GUIText moneyText;
	public GUIText foodText;
	public GUIText waterText;
	public GUIText educationText;

	// Use this for initialization
	void Start () {
	}

	void Update(){
		populationText.text= "Population: "+ Population+" / "+ (PopulationIncrease-PopulationDecrease) ;
		moneyText.text = "Money: " + Money+" / "+ (MoneyIncrease-MoneyDecrease) ;
		foodText.text = "Food: " + Food+" / "+ (FoodIncrease-FoodDecrease) ;
		waterText.text = "Water: " + Water+" / "+ (WaterIncrease-WaterDecrease) ;
		educationText.text = "Education: " + Education+" / "+ (EducationIncrease-EducationDecrease) ;
	}

	private void Reset()
	{
		MoneyIncrease = 400000;
		FoodIncrease = 0;
		WaterIncrease = 0;
		EducationIncrease = 0;

		MoneyDecrease = 0;
		FoodDecrease = 0;
		WaterDecrease = 0;
		EducationDecrease = 0;
	}

	public void Apply() //Apply changes
	{
		Population = (int)(Population * (PopulationIncrease - PopulationDecrease));

		Money += MoneyIncrease - MoneyDecrease;
		Food += FoodIncrease - FoodDecrease;
		Water += WaterIncrease - WaterDecrease;
		Education += EducationIncrease - EducationDecrease;

		Reset ();
	}

	public void Print()
	{
		Debug.Log ("Food:" + Food);
		Debug.Log ("Water:" + Water);
		Debug.Log ("Money:" + Money);
		Debug.Log ("Education:" + Education);
		Debug.Log ("Population:" + Population);
	}

	public void ConvertToMoney()
	{
		//if money or food is below 0
		int factor = 200;

		if (Food < 0) {
			int penalty = factor * -(Food);
			Money -= penalty;
			Food = 0;
			Debug.Log ("Spent " + penalty + " because of food shortage"); 
		}

		if (Water < 0) {
			int penalty = factor * -(Water);
			Money -= penalty;
			Water = 0;
			Debug.Log ("Spent " + penalty + " because of water shortage"); 
		}

	}
}
