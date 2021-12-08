using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneActivate : MonoBehaviour
{
    public GameObject[] Lanes;
    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("RandComp", 6, 10);
    }

    public void Reset()
    {
        Lanes[0].SetActive(false);
        Lanes[1].SetActive(false);
        Lanes[2].SetActive(false);
        Lanes[3].SetActive(false);
        Lanes[4].SetActive(false);
    }
    void RandComp()
    {
        Reset();
        if (AlienSpawn.randLane == 0)
        {
            Lanes[0].SetActive(true);
        }
        else if(AlienSpawn.randLane == 1)
        {
            Lanes[1].SetActive(true);
        }
        else if (AlienSpawn.randLane == 2)
        {
            Lanes[2].SetActive(true);
        }
        else if (AlienSpawn.randLane == 3)
        {
            Lanes[3].SetActive(true);
        }
        else
        {
            Lanes[4].SetActive(true);
        }
        // Reset();
    }
   
}
