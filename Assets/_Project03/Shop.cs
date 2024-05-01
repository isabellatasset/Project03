using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
[Header("Shop Information")]
[SerializeField]
private string _name;

[Header("Shop Keeper's Change to Barter")]
[SerializeField]
[Range(0,50)]
[tooltip("You can change the chances shopkeeper will barter with player!")]
private float _chanceToBarter;

[Header("Weapon Prices")]
[SerializeField]
private int _Sword;
[SerializeField]
private int _Axe;
[SerializeField]
private int _Spear;

[Header("Potions Prices")]
[SerializeField]
private int _Health;
[SerializeField]
private int _Speed;
[SerializeField]
private int _Invisibility;

[Header("Dialogue")]
[SerializeField]
[tooltip("Shopkeeper speaks upon player detection")]
[Range(0,10)]
private int _detectionRadius;
[TextArea()]
private string _shopKeeperDialogue;


}
