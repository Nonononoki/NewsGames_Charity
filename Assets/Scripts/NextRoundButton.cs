using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NexRoundButton : MonoBehaviour {

	public Resources Resources;

	void OnMouseDown()
	{
		//calculate Resources

		//farm
		int NewFood = 0;
		foreach (Farm f in Farm.getList()) 
		{
			NewFood += f.Produce;
		}
		Resources.FoodIncrease = NewFood;

		//well
		int NewWater = 0;
		foreach (Well w in Well.getList()) 
		{
			NewWater += w.Produce;
		}
		Resources.WaterIncrease = NewWater;

		//education
		int NewEducation = 0;
		foreach (School e in School.getList()) 
		{
			NewEducation += e.Produce;
		}
		Resources.EducationIncrease = NewWater;


		//Resources.
	} 
}
