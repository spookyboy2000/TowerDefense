using UnityEngine;
using System.Collections;

[System.Serializable]
public class TurretBlueprint : MonoBehaviour
{

	public GameObject prefab;
	public int cost;

	public GameObject upgradedPrefab;
	public int upgradeCost;

	public int GetSellAmount()
	{
		return cost / 2;
	}

}