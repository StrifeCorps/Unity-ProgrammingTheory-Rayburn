using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] protected int scoreValue;
	[SerializeField] private bool spinObject;

	public UnityEvent<int> ObjectDestroyed;

	private void Start()
	{
		ObjectDestroyed.AddListener(GameManager.Instance.UIManager.UpdateScoreUI);
		StartCoroutine(RotateObject());
		StartCoroutine(DestroyTimer());
	}

	private IEnumerator DestroyTimer()
	{
		yield return new WaitForSeconds(3);
		Destroy(gameObject);
	}

	virtual public void OnMouseDown()
	{
		ObjectDestroyed.Invoke(scoreValue);
		Destroy(gameObject);
	}

	virtual public IEnumerator RotateObject() 
	{
		while (spinObject)
		{
			transform.Rotate(Vector3.up);
			yield return new WaitForSeconds(.01f);
		}
	}
}
