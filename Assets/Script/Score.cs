using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TMP_Text scoreText;

    private int scoreNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        scoreNum = 0;
        scoreText.text = "Coins:" + scoreNum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin")) {
            scoreNum++;
            Destroy(other.gameObject);
            scoreText.text = "Coins:" + scoreNum;
        }
    }
}
