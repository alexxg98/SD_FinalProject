using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Gives us access to load scenes/levels

public class Start : MonoBehaviour
{
    public string gameSceneName; //the name of our game scene

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName); //loads the game scene again
    }
}
