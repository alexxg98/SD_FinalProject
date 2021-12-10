using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{
    public GameObject[] AlienWaves;
    public void SpawnWave()
    {
        AlienWaves[1].SetActive(true);
    }


}
