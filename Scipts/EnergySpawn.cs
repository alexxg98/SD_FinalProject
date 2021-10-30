using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergySpawn : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        // Spawn first Energy after 5 secs, and every 5 secs afterwards
        InvokeRepeating("Spawn", 5, 5);
    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}