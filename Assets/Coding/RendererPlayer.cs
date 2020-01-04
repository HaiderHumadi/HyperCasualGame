using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendererPlayer : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();

        m_SpriteRenderer.enabled = true;
    }

    
    void OnCollisionEnter2D(Collision2D rcol) {

        if (rcol.gameObject.CompareTag("Enemy")) {

            m_SpriteRenderer.enabled = false;

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
