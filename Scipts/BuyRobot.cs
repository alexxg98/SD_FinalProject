using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyRobot : MonoBehaviour
{
    private void OnMouseDown()
    {
        int robotCost = SelectRobot.robotCost;
        // Check if player selected robot to buy, if not nothing
        if (SelectRobot.selectedRobot == null)
        {
            return;
        }

        // Insantiate robot if enough funds
        if (EnergyCollect.energyTotal >= robotCost)
        {
            EnergyCollect.energyTotal -= robotCost;
            Spawn();
            //Debug.Log("Robot Spawned");

            // "Deactivate" button
            // Buy one robot at a time
            SelectRobot.selectedRobot = null;
            SelectRobot.robotCost = 1000; // Ensures no double robot click instantiatization
            SelectRobot.clickedCast.SetActive(false);
        }
        else
        {
            return;
        }
    }

    void Spawn()
    {
        // Get position of mouse click
        // instantiate where mouse is clicked
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnPosition.z = 0.0f;
        Instantiate(SelectRobot.selectedRobot, spawnPosition, Quaternion.identity);
    }
}
