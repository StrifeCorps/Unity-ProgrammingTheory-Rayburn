using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
	private void Start()
	{
		GameManager.Instance.UIManager.scoreText = this.GetComponent<TMP_Text>();
	}
}
