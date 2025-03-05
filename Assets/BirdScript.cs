using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Ok";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();


    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;

        }
    }

    // ngubah dari code
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
