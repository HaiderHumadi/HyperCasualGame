using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{

 
    public ParticleSystem effects;
    // Start is called before the first frame update
   private void Start()
    {
        effects.GetComponent<ParticleSystem>();
        
    }

  
    
    private void OnCollisionEnter2d(Collision sparkle)
    {
        if (sparkle.gameObject.tag == "Player") {

            effects.Play();

        }
    }
}
