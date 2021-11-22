using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyRobot : MonoBehaviour
{
    //public static int robotPick;
    public GameObject atackerPrefab;
    int clickCount = 0;
    public void AttackerBuy()
    {
        Debug.Log("Attacker clicked");
        
        if (clickCount > 0)
        {
            Spawn();
            clickCount = 0;
        }
        else
        {
            clickCount++;
        }

        
    }

    void Spawn()
    {
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnPosition.z = 0.0f;
        Instantiate(atackerPrefab, spawnPosition, Quaternion.identity);
    }
}
