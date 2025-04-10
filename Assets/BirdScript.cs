using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody2D;

    public float flapStrength;

    public LogicManagerScript logicManagerScript;

    public bool isBirdAlive = true;

    void Start()
    {
        logicManagerScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isBirdAlive )
        {

            //Vector2.up is shorthand for (0,1)
            myRigidBody2D.velocity = Vector2.up * flapStrength;
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        logicManagerScript.gameOver();
        isBirdAlive = false;

    }
}

