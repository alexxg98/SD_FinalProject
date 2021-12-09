using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBase : MonoBehaviour
{
    public static int hp = 30;
    void Update()
    {
        CheckHealth();
        Debug.Log("Health = " + hp);
    }
    public void CheckHealth()
    {
        if (hp <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    
}
