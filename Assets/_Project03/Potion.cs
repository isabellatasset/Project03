using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
[SerializeField]
private PotionData _data;

public PotionData Data => _data;

private void Awake()
{
    Debug.Log("Name: " + _data.Name);
}
}
