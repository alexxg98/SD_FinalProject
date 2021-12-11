using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCollect : MonoBehaviour
{
    public static int energyTotal;

    private void OnMouseDown()
    {
        // Collect Energy
        energyTotal += 50;
        //Debug.Log("Engery: " + energyTotal);

        // Destroy Energy object after collecting
        Destroy(gameObject);
    }
}
