using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoundButton : MonoBehaviour {

	public Resources Resources;
	public infoBox ib;

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

		string s = "";

		Resources.Print ();
		//Apply penalty
		if(Resources.Food < 0 || Resources.Water < 0)
		{
			Resources.ConvertToMoney(ref s);
			if (Lose ()) {
				s = "No money left, you lost!";
				Debug.Log ("No money left, you lost!");

				ib.Show (s);
			}
			ib.Show(s);
		} 
		//win/Lose condition
		if (Win ()) {
			s = "Everyone is educated! You Win!";
			Debug.Log ("Everyone is educated! You Win!");

			ib.Show(s);
		}

		Resources.Apply ();
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
		if (Resources.Education >= Resources.Population)
			return true;
		else
			return false;
	}

	void OnMouseDown()
	{
		NextRound ();
	}
}
