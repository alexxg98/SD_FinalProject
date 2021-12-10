using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    // GameManager.gameMF gf = new GameManager.gameMF();
    public int countDownTime;
    public TextMeshProUGUI timerUI;
    public int GetTime()
    {
        return countDownTime;
    }
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(countDownTimer());
    }
    IEnumerator countDownTimer()
    {
        while (countDownTime > 0)
        {
            if (countDownTime == 35)
            {
                Debug.Log("Spawn!");
                FindObjectOfType<Waves>().SpawnWave();
            }
            timerUI.text = "Time: " + countDownTime.ToString();
            yield return new WaitForSeconds(1f);
            countDownTime--;
        }
        Debug.Log("Time: " + countDownTime.ToString());
        timerUI.text = "Game Over!";
        //yield return new WaitForSeconds(1f);
        if (countDownTime == 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
