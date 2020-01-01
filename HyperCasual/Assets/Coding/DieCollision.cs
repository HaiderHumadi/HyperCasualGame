using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DieCollision : MonoBehaviour
{ //in the project tab of Unity, make a new "C# Script" called "DestroyCollision"

    public AudioSource hitwall;
    
     
    
    private void Start()
    {
        hitwall = GetComponent<AudioSource>();
        
    }
 

    public string Player; //this will show up as an input box for the component, which can be given a tag of your choice.  assign the 

    void OnCollisionEnter2D(Collision2D myCol)
    {

        
        
        //run the following whenever a collision happens to the object attached with this script
        Debug.Log("Collision with " + myCol.gameObject);
        if (myCol.gameObject.tag == "Player")
        { //does the object collided with have the tag in question?
            Destroy(myCol.gameObject); //if so, destroy that object!
            hitwall.Play();
            

            Invoke("DelayedAction", 0.5f);
            //Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
            
        }

        

        }

    void DelayedAction() {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
}


