using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollisions : MonoBehaviour
{
    public ParticleSystem effects;
    // Start is called before the first frame update
    private void Start()
    {
        effects.GetComponent<ParticleSystem>();
        effects.Stop();
    }
    void OnCollisionEnter2D(Collision2D sparkle) { 
    if (sparkle.gameObject.CompareTag("Enemy")) {

            effects.Play();
        }
}
        }


    
    

