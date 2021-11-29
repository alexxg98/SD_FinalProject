using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverMenu;
    public static bool gameOver = false;
    public static bool gameHalted = false;

    public static void EndGame()
    {
        if (gameOver == false)
        {
            gameOver = true;
            Debug.Log("Game Over");
            Time.timeScale = 0f;
            // GameOverMenu.SetActive(true);
            gameHalted = true;
        }
    }

}