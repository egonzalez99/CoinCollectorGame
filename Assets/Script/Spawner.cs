using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objects;

    float minX = -5f;
    float maxX = 5f;

    float YPos = 10f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 3.0f, 3.0f);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObjects()
    {

        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, YPos, 0);
        int randomIndex = Random.Range(0, objects.Length);
        Instantiate(objects[randomIndex], spawnPosition, Quaternion.identity);
        

    }
}
