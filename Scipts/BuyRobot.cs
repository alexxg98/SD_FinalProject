using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyRobot : MonoBehaviour
{
    private void OnMouseDown()
    {
        int robotCost = SelectRobot.robotCost;
        if (EnergyCollect.energyTotal >= robotCost)
        {
            EnergyCollect.energyTotal -= robotCost;
            Spawn();
            Debug.Log("Robot Spawned");

            // "Deactivate" button
            SelectRobot.selectedRobot = null;
            SelectRobot.robotCost = 1000;
            SelectRobot.clickedCast.SetActive(false);
        }
        else
        {
            return;
        }
    }

    void Spawn()
    {
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnPosition.z = 0.0f;
        Instantiate(SelectRobot.selectedRobot, spawnPosition, Quaternion.identity);
    }
}
