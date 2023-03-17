using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        playerMove();
       
    }

    private void playerMove()
    {
        float xMove = Input.GetAxisRaw("Horizontal");

        transform.Translate(xMove * playerSpeed * Time.deltaTime, 0, 0);

    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Coin")) {
            Destroy(other.gameObject);
            
        }
        
        if (other.CompareTag("Hazard"))
        {
            Destroy(other.gameObject);

        }

        if (other.CompareTag("ThemeBox"))
        {
            
            Destroy(other.gameObject);

        }
        
    }
   

}
