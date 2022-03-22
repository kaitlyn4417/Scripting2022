using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject[] animalPrefabs;
	private float spawnRangeX = 10;
	private float spawnPosZ = 20;
	private float spawnDelay = 3;
	private float spawnInterval = 2;

    // Start is called before the first frame update
    void Start()
    {
		//spawns animal at random times
        InvokeRepeating("spawnRandomAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

//spawns random animal
	void spawnRandomAnimal()
	{
		int animalIndex = Random.Range(0, animalPrefabs.Length);
			Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

			Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
	}
}
