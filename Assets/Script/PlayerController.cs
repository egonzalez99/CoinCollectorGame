using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float coinSpeed;
    public float hazardSpeed;
    public float themeSpeed;

    public GameObject coin;
    public GameObject hazard;
    public GameObject themeBox;

    float minX = -5f;
    float maxX = 5f;

    float minY = 7f;
    float maxY = 8f;

    float maxSpawn = 3;
    float spawnCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        playerMove();
        /*
        SpawnCoin();
            
        SpawnHazard();

        SpawnTheme();
        */
    }

    private void playerMove()
    {
        float xMove = Input.GetAxisRaw("Horizontal");

        transform.Translate(xMove * playerSpeed * Time.deltaTime, 0, 0);

    }
    /*
    private void SpawnCoin()
    {
        if (spawnCounter <= maxSpawn)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            Vector3 spawnPosition = new Vector3(randomX, randomY, 0);
            Instantiate(coin, spawnPosition, Quaternion.identity);

            transform.Translate(Vector3.down * coinSpeed * Time.deltaTime);
            spawnCounter++;
        }
    }

    private void SpawnHazard()
    {
        if (spawnCounter <= maxSpawn)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            Vector3 spawnPosition = new Vector3(randomX, randomY, 0);
            Instantiate(hazard, spawnPosition, Quaternion.identity);

            transform.Translate(Vector3.down * hazardSpeed * Time.deltaTime);
            spawnCounter++;
        }
    }

    private void SpawnTheme()
    {
        if (spawnCounter <= maxSpawn)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            Vector3 spawnPosition = new Vector3(randomX, randomY, 0);
            Instantiate(themeBox, spawnPosition, Quaternion.identity);

            transform.Translate(Vector3.down * themeSpeed * Time.deltaTime);
            spawnCounter++;
        }
    }

    */

}
