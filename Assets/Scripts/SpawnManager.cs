using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject catPrefab;
    public GameObject dogPrefab;
    public GameObject chiPrefab;
    public GameObject huskyPrefab;
    //private GameObject[] animals = new GameObject[4];
    private float spawnRange=8.0f;
    //private GameObject[] animalsPrefabs;
    static public List<GameObject> animals = new List<GameObject>();

    //private List<String> animals = new List<String>();
    // Start is called before the first frame update
    void Start()
    {
        animals.Add(catPrefab);
        animals.Add(dogPrefab);
        animals.Add(chiPrefab);
        animals.Add(huskyPrefab);
        SpawnAnimals();
    }

    private void SpawnAnimals()
    {
        foreach (var animal in animals)
        {
            for (int i = 0; i < UnityEngine.Random.Range(2,5); i++)
            {
                Instantiate(animal,GenerateSpawnPosition(),animal.transform.rotation);
            }
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX= UnityEngine.Random.Range(-spawnRange,spawnRange);
        float spawnPosZ=UnityEngine.Random.Range(-spawnRange,spawnRange);
        Vector3 spawnPos= new Vector3(spawnPosX,2,spawnPosZ);

        return spawnPos;
    }
}
