﻿using System.Collections;
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

	public TextMesh populationText;
	public TextMesh moneyText;
	public TextMesh foodText;
	public TextMesh waterText;
	public TextMesh educationText;

	public TextMesh populationIncreaseText;
	public TextMesh moneyIncreaseText;
	public TextMesh foodIncreaseText;
	public TextMesh waterIncreaseText;
	public TextMesh educationIncreaseText;

	// Use this for initialization
	void Start () {
		Apply ();
	}


	void Update()
	{
	}

	private void Reset()
	{
		MoneyIncrease = 400000;
		FoodIncrease = 0;
		WaterIncrease = 0;
		EducationIncrease = 0;

		MoneyDecrease = 0;
		FoodDecrease = Population;
		WaterDecrease = Population;
		EducationDecrease = 0;

	}

	public void Apply() //Apply changes
	{
		Debug.Log ("Applying...");
		Reset ();

		populationText.text= Population.ToString();
		moneyText.text = Money.ToString ();
		foodText.text = Food.ToString();
		waterText.text = Water.ToString();
		educationText.text = Education.ToString();

			
		if(Farm._farmList != null)
			foreach (Farm f in Farm._farmList) {
				FoodIncrease += f.Produce;
				MoneyDecrease += f.Maintainance;
			}
		if(Well._wellList != null)
			foreach (Well w in Well._wellList) {
				WaterIncrease += w.Produce;
				MoneyDecrease += w.Maintainance;
			}
		if(School._schoolList != null)
			foreach (School s in School._schoolList) {
				EducationIncrease += s.Produce;
				MoneyDecrease += s.Maintainance;
			}

		foodIncreaseText.text = (FoodIncrease - FoodDecrease).ToString() ;
		waterIncreaseText.text = (WaterIncrease - WaterDecrease).ToString() ;
		educationIncreaseText.text = (EducationIncrease - EducationDecrease).ToString();
		populationIncreaseText.text= ((int)-(Population - Population*(PopulationIncrease - PopulationDecrease))).ToString();
		moneyIncreaseText.text = (MoneyIncrease-MoneyDecrease).ToString();
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
		const int factor = 200;

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
