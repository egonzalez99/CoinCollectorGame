using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float coinSpeed;

    public GameObject coin;

    float minX = -5f;
    float maxX = 5f;

    float minY = 7f;
    float maxY = 8f;

    float maxSpawn = 1f;
    float spawnCounter = 0f;

    bool isCoinSpawned = false;
    // Start is called before the first frame update
    void Start()
    {
       SpawnCoin();
 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * coinSpeed * Time.deltaTime);

    }


    private void SpawnCoin()
    {
        
        if (spawnCounter < maxSpawn)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            Vector3 spawnPosition = new Vector3(randomX, randomY, 0);
            Instantiate(coin, spawnPosition, Quaternion.identity);

            
            spawnCounter++;

        }

    }


}