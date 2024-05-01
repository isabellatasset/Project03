using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

[SerializeField]
private ShopData _data;

public ShopData Data => _data;

private void Awake()
{
    Debug.Log("Name: " + _data.Name);
    Debug.Log("Rarity:" + _data.Rarity);
}

}
