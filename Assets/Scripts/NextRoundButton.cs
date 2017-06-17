using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoundButton : MonoBehaviour {

	public Resources Resources;

	public void NextRound()
	{
		//decrease water and food
		Resources.Water += Resources.WaterIncrease - Resources.WaterDecrease;
		Resources.Food += Resources.FoodIncrease - Resources.FoodDecrease;

		//increase education
		Resources.Education += Resources.EducationIncrease - Resources.EducationDecrease;

		//decrease money
		Resources.Money += Resources.MoneyIncrease - Resources.MoneyDecrease;

		//increase population
		Resources.Population = (int)(Resources.Population * (Resources.PopulationIncrease - Resources.PopulationDecrease)); 

		Debug.Log (Resources.MoneyDecrease + "Euros lost because of maintenance!");

		Resources.ConvertToMoney();
		Resources.Print ();
		Resources.Apply ();

		//win/Lose condition
		if (Lose ())
			Debug.Log ("No money left, you lost!");
		else if (Win ())
			Debug.Log ("Education level reached 100%! You Win!");
		
	} 

	bool Lose()
	{
		if (Resources.Money <= 0)
			return true;
		else
			return false;
	}

	bool Win()
	{
		if (Resources.Education >= 100)
			return true;
		else
			return false;
	}

	void OnMouseDown()
	{
		NextRound ();
	}
}
