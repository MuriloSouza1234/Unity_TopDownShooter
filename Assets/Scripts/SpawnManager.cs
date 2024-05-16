using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{   public GameObject [] animalPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;
    private float startSpawning = 2;
    private float delaySpawning = 1.5f;

    void SpawnAnimal()
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0, spawnPosZ);
            int animalIndex = Random.Range(0 , animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos , animalPrefabs[animalIndex].transform.rotation);
            
        }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", startSpawning, delaySpawning);
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
}
