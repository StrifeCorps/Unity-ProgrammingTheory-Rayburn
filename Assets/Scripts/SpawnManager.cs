using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float spawnVerticalBound;
    [SerializeField] private float spawnHorizontalBound;
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject bomb;
    [SerializeField] private int spawnTimer;
    private Vector3 spawnPosition;

	private void Start()
	{
        StartCoroutine(SpawnTimer(spawnTimer, true));
	}

	void GenerateSpawnLocation()
    {
        spawnPosition = new Vector3(Random.Range(-spawnHorizontalBound, spawnHorizontalBound), Random.Range(-spawnVerticalBound, spawnVerticalBound), 0);
    }

    void SpawnGamePiece()
    {
        GenerateSpawnLocation();
        Instantiate(coin, spawnPosition, coin.transform.rotation);
    }

    IEnumerator SpawnTimer(int _timer, bool _continue) 
    {
        while (_continue)
        {
            SpawnGamePiece();
            yield return new WaitForSeconds(_timer);
        }
	}
}
