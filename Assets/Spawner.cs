using System;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject obstaclePrefab;
    
    public float timeToSpawn = 2f;
    public float timeBetweenWaves = 1f;

    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnRow();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    private void SpawnRow()
    {
        int randomIndex = UnityEngine.Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < spawnPoints.Length; i++)
            if (i != randomIndex)
                Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity);
    }
}
