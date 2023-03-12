using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float coinSpeed;
    public float hazardSpeed;
    public float themeSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();

        coinMove();

        hazardMove();

        themeMove();

    }

    private void playerMove()
    {
        float xMove = Input.GetAxisRaw("Horizontal");

        transform.Translate(xMove * playerSpeed * Time.deltaTime, 0, 0);

    }

    private void coinMove()
    {

        transform.Translate(Vector3.down * coinSpeed * Time.deltaTime);
    
    }

    private void hazardMove()
    {

        transform.Translate(Vector3.down * hazardSpeed * Time.deltaTime);

    }

    private void themeMove()
    {

        transform.Translate(Vector3.down * themeSpeed * Time.deltaTime);

    }

}
