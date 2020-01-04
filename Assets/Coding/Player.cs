using UnityEngine;
using System.Collections;
using UnityEngine;

public class PushBack : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballforce;
    void Start()
    {
        rb.AddForce(new Vector2(ballforce, ballforce));
    }
}