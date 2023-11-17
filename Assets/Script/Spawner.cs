using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfCubes = 100;
    public float spawnRadius = 10.0f;

    private void Start()
    {
        SpawnCubes();        
    }

    private void SpawnCubes()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-5f, 25f), Random.Range (6f, 15), Random.Range(-5f, 25f));
            Instantiate(prefab, randomPos, Quaternion.identity);
        }
    }
}
