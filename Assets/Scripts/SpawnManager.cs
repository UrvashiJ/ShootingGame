// spawnmanager - is an empty object 
// this code is for releasing random animals in the play area randomly 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;  // this an array of the animals which we want to come randomly 
                                        // the size of the array - the number of items is required to be added in the unity editor
                                        // and accordingly add the elements wrt to the required prefabs 
    private float spawnRangeX = 10;
    private float spawnPosZ = 30;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); //a method, that invokes whatever method we want at desired time and will constantly repeate it 
        // calling the spwanrandomanimal after 2 secs and then after every 1.5 secs
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)) // the animals will spawn when S is pressed randomly
        {
            SpawnRandomAnimal();  
        }
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);//for generating random animals random is the class - range is the method - here this range will take 0 1 2 
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); // creating a new variable spawnPos - to decide the position of the animal
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        // initiate the 0 array element 
        // at location - newvector3 on the position 
        // and lastly taking the rotation of the animal

    }
}
