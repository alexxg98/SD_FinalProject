using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBase : MonoBehaviour
{
    public static int homebaseHP = 100;
    
    public static void CheckHealth()
    {
        //Debug.Log(homebaseHP);
        if (homebaseHP <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
            homebaseHP = 100;
        }
    }
}