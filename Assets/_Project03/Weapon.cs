using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
[SerializeField]
private WeaponData _data;

public WeaponData Data => _data;

private void Awake()
{
    Debug.Log("Name: " + _data.Name);
}
}
