using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    public static Health instance;
    public GameObject gameOverText;
    public bool gameOver = false;


     void Awake()
    {
        if (instance == null)
        {


            instance = this;
        }
        else if (instance != this) {

            Destroy (gameObject);

        }
    }

    public static int health;
    // Start is called before the first frame update
    void Start()
    {
        


    }

    void OnCollisionEnter2D(Collision2D myCol)
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.touchCount > 0) {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

    public void death()
    {
        if (health <= 0)
        {

            gameOverText.SetActive(true);
            gameOver = true;


        }
    }
    
}
