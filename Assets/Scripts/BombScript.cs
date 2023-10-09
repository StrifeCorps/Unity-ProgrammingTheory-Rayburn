using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : InteractableObject
{

	public override void OnMouseDown()
	{
		ObjectDestroyed.Invoke(scoreValue);

		InteractableObject[] _coins = GameObject.FindObjectsOfType<InteractableObject>();

		foreach (InteractableObject coin in _coins)
		{
			Destroy(coin.gameObject);
		}
	}
}
