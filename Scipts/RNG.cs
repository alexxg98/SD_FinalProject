using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNG : MonoBehaviour
{
    public static int randLane;

    public static void Rngenerator()
    {
        randLane = Random.Range(0, FindObjectOfType<LaneActivate>().Lanes.Length);
        Debug.Log("#: " + randLane);
    }
}
