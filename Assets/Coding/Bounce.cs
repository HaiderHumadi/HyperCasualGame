using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballforce;

    public Vector3 pos;
    void Start()
    {
        pos = transform.position;
        rb.AddRelativeForce(new Vector2(ballforce, ballforce));
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < 0)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                rb.AddRelativeForce(new Vector2((ballforce * 2), (ballforce)));

            }


        }
        else
        {
        }   
            if (Input.GetKeyUp(KeyCode.Space))
            {
                rb.AddRelativeForce(new Vector2((ballforce*-2), (ballforce)));
            }

            if (transform.position.y < 0)
            {
                if (Input.GetKeyUp(KeyCode.Space))
                {
                    rb.AddRelativeForce(new Vector2((ballforce), (ballforce * 2)));

                }


            }
            else
            {

                if (Input.GetKeyUp(KeyCode.Space))
                {
                    rb.AddRelativeForce(new Vector2((ballforce * -2), (ballforce)));
                }
            }
    }
}

 
// if then statement that keeps blockes a certain distance away from the cube  1
// if then statement that randomizes block location to each other by a certain distance  2
// add a timer  
// randomzie coins
// if then statemnt more time spent in game reduce 1 and 2 
