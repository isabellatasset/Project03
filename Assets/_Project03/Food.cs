using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
[SerializeField]
private FoodData _data;

public FoodData Data => _data;

private void Awake()
{
    Debug.Log("Name: " + _data.Name);
}
}
