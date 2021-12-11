using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{
    public GameObject[] AlienWaves;
    public void SpawnWave()
    {
        // Activate second wave of aliens
        AlienWaves[1].SetActive(true);
    }


}