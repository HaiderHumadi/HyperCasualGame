using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision wall) 
    {
        float dist = this.transform.position.y - GameObject.FindWithTag ("Wall").transform.position.y;

        if (wall.gameObject.tag == "Wall") {

            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, 0f);

        }
    }
}
