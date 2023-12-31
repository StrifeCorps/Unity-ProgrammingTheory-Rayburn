using System.Collections;
using System.Collections.Generic;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;
    [SerializeField] private int totalScore;

	public void UpdateScoreUI(int _score)
    {
        totalScore += _score;
		scoreText.text = $"Score: {totalScore}";
    }

    private void ResetScore()
    {
        totalScore = 0;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
	}

    public void LoadMainMenu()
    {
        GameManager.Instance.UIManager.ResetScore();
        SceneManager.LoadScene(0);
	}

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
