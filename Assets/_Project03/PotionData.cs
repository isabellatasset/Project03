using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PotionData_", menuName ="UnityData/Potion")]

public class PotionData : ScriptableObject
{
[Header("Potion Information")]
[SerializeField]
private string _name;

[Header("Chance of Selling Potion")]
[SerializeField]
private PotionClass _potionClass = PotionClass.None;
[SerializeField]
[Range(0,30)]
[Tooltip("You can change the chances shopkeeper will sell this item to player!")]
private float _chanceToSell;

[Header("Potion Potency")]
[SerializeField]
private int _Potency;

public string Name => _name;

}
