using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int index;
    public string levelName;

    private void OnTriggerEnter2D(Collider2D change)
    {
        if (change.gameObject.CompareTag("Player")) {

            SceneManager.LoadScene(index);

            SceneManager.LoadScene(levelName);

        }
    }
}
