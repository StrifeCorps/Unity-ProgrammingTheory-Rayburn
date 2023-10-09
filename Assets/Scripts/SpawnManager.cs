using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float spawnVerticalBound;
    [SerializeField] private float spawnHorizontalBound;
    [SerializeField] private GameObject[] spawnObjects;
    [SerializeField] private int coinSpawnTimer;
    [SerializeField] private int bombSpawnTimer;
    private Vector3 spawnPosition;

	private void Start()
	{
        StartCoroutine(SpawnTimer(coinSpawnTimer, true, spawnObjects[0]));
		StartCoroutine(SpawnTimer(bombSpawnTimer, true, spawnObjects[1]));
	}

	void GenerateSpawnLocation()
    {
        spawnPosition = new Vector3(Random.Range(-spawnHorizontalBound, spawnHorizontalBound), Random.Range(-spawnVerticalBound, spawnVerticalBound), 0);
    }

    void SpawnGamePiece(GameObject _object)
    {
        GenerateSpawnLocation();
        Instantiate(_object, spawnPosition, _object.transform.rotation);
    }

    IEnumerator SpawnTimer(int _timer, bool _continue, GameObject _object) 
    {
        while (_continue)
        {
            SpawnGamePiece(_object);
            yield return new WaitForSeconds(_timer);
        }
	}
}
