using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCollect : MonoBehaviour
{
    // Global variable
    // Player starts with 50 Enery
    public static int energyTotal = 50;

    private void OnMouseDown()
    {
        // Collect Energy
        energyTotal += 50;

        // Destroy Energy object after collecting
        Destroy(gameObject);
    }
}
