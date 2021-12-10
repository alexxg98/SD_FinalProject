using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneActivate : MonoBehaviour
{
    public GameObject[] Lanes;
    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("RandComp", 5, AlienSpawn.randSpawn-1);
    }

    public void Reset()
    {
        Lanes[0].SetActive(false);
        Lanes[1].SetActive(false);
        Lanes[2].SetActive(false);
        Lanes[3].SetActive(false);
        Lanes[4].SetActive(false);
        RNG.Rngenerator();
    }
    void RandComp()
    {
        Reset();
        if (RNG.randLane == 0)
        {
            Lanes[0].SetActive(true);
        }
        else if(RNG.randLane == 1)
        {
            Lanes[1].SetActive(true);
        }
        else if (RNG.randLane == 2)
        {
            Lanes[2].SetActive(true);
        }
        else if (RNG.randLane == 3)
        {
            Lanes[3].SetActive(true);
        }
        else
        {
            Lanes[4].SetActive(true);
        }
    }
   
}
