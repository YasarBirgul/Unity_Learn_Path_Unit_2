using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMan : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    private float spawnRangeX = 4.3f;
    private float spawnPosZ = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",2f,3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(AnimalPrefabs[animalIndex], spawnPos,AnimalPrefabs[animalIndex].transform.rotation);
    }
    
    
    
    
}
