using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneActivate : MonoBehaviour
{
    // Insert array of lanes
    public GameObject[] Lanes;
    private int randLane;

    public void Rng()
    {
        System.Random r = new System.Random();
        randLane = r.Next(0, 5);
        //Debug.Log("Lane Index #: " + randLane);
    }
    public void Reset()
    {
        Lanes[0].SetActive(false);
        Lanes[1].SetActive(false);
        Lanes[2].SetActive(false);
        Lanes[3].SetActive(false);
        Lanes[4].SetActive(false);
        Rng();
    }
    public void RandComp()
    {
        // Select random lane for alien to traverse
        Reset();
        if (randLane == 0)
        {
            Lanes[0].SetActive(true);
        }
        else if (randLane == 1)
        {
            Lanes[1].SetActive(true);
        }
        else if (randLane == 2)
        {
            Lanes[2].SetActive(true);
        }
        else if (randLane == 3)
        {
            Lanes[3].SetActive(true);
        }
        else
        {
            Lanes[4].SetActive(true);
        }
    }
}