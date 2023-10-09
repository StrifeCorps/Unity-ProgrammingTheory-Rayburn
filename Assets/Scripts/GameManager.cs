using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
	public UIManager UIManager;
	AudioSource audio;

	private void Awake()
	{
		audio = GetComponent<AudioSource>();
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
			audio.Play();
		}
	}
}
