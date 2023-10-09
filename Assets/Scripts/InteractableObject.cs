using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private int scoreValue;

	public UnityEvent<int> ObjectDestroyed;

	private void Start()
	{
		ObjectDestroyed.AddListener(GameManager.Instance.UIManager.UpdateScoreUI);
	}

	virtual public void OnMouseDown()
	{
		ObjectDestroyed.Invoke(scoreValue);
		Destroy(gameObject);
	}
}
