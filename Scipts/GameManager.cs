using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] gameOverUI;
    public static bool gameOver = false;
    public static bool gameHalted = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameHalted)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }

        }
    }
    public void ResumeGame()
    {
        gameOverUI[2].SetActive(false);
        Time.timeScale = 1f;
        gameHalted = false;
    }
    public void PauseGame()
    {
        gameOverUI[2].SetActive(true);
        Time.timeScale = 0f;
        gameHalted = true;
    }
    public void EndGame()
    {
        if (gameOver == false)
        {
            gameOver = true;
            //Debug.Log("Game Over");
            if (FindObjectOfType<TimeController>().countDownTime <= 0)
            {
                gameOverUI[0].SetActive(true);
            }
            else if (CoilCollect.coilCollection >= 5)
            {
                gameOverUI[0].SetActive(true);
            }
            else
            {
                gameOverUI[1].SetActive(true);
            }

            Time.timeScale = 0f;
            gameHalted = true;
        }
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("PlayGame");
        Time.timeScale = 1f;
        gameHalted = false;
        gameOver = false;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}