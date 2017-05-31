using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevel;

    private void Start()
    {
        Invoke("loadNextLevel", autoLoadNextLevel);
    }

    public void loadLevel(string name)
    {

        print("Level Load Requested For: " + name);
        //Application.LoadLevel(name); OLD CODE

        //Use this when managing scenes that go in order.
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(name);
    }
    public void quitRequest(string name)
    {
        print(name);
        Application.Quit();
    }
    public void loadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void delayLevel(string name)
    {

    }
}
