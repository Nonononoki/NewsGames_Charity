using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoundButton : MonoBehaviour {

	public Resources Resources;

	public void NextRound()
	{
		//calculate Resources
		int maintenance = 0;

		//farm
		int NewFood = 0;
		foreach (Farm f in Farm.getList()) 
		{
			NewFood += f.Produce;
			maintenance += f.Maintainance;
		}
		Resources.FoodIncrease = NewFood;

		//well
		int NewWater = 0;
		foreach (Well w in Well.getList()) 
		{
			NewWater += w.Produce;
			maintenance += w.Maintainance;
		}
		Resources.WaterIncrease = NewWater;

		//education
		int NewEducation = 0;
		foreach (School s in School.getList()) 
		{
			NewEducation += s.Produce;
			maintenance += s.Maintainance;
		}
		Resources.EducationIncrease = NewEducation;


		//decrease water and food
		Resources.WaterDecrease = Resources.Population;
		Resources.FoodDecrease = Resources.Population;

		//decrease money
		Resources.MoneyDecrease = maintenance;
		Debug.Log (maintenance + "Euros lost because of maintenance!");


		Resources.Apply ();
		Resources.ConvertToMoney ();
		Resources.Print ();

		//win/Lose condition
		if (Win ())
			Debug.Log ("Education level reached 100%! You Win!");
		else if (Lose ())
			Debug.Log ("No money left, you lost!");
		
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
}
