using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FoodData_", menuName ="UnityData/Food")]

public class FoodData : ScriptableObject
{
[Header("Food Name")]
[SerializeField]
private string _name;

[Header("How Satiating is this Meal?")]
[SerializeField]
private FoodClass _foodClass = FoodClass.None;
[SerializeField]
[Range(0,100)]
[Tooltip("You can change how full this meal will make the player")]
private float _Satiation;

[Header("Food Density")]
[SerializeField]
private int _Density;

public string Name => _name;
}
