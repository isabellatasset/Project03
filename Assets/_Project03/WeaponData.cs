using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponData_", menuName ="UnityData/Weapon")]

public class WeaponData : ScriptableObject
{
[Header("Weapon Information")]
[SerializeField]
private string _name;

[Header("Chance of Selling Weapon")]
[SerializeField]
private WeaponClass _weaponClass = WeaponClass.None;
[SerializeField]
[Range(0,30)]
[Tooltip("You can change the chances shopkeeper will sell this item to player!")]
private float _chanceToSell;

[Header("Weapon Damage")]
[SerializeField]
private int _Damage;

public string Name => _name;
}
