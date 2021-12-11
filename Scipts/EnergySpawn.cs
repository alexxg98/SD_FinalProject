using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergySpawn : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        // Spawn first Energy after 4 secs, and every 5 secs afterwards
        InvokeRepeating("Spawn", 4, 9);
    }

    void Spawn()
    {
        GameObject energy = Instantiate(prefab, transform.position, Quaternion.identity);
        Destroy(energy, 7); // Destroy energy if not collected after 7 secs
    }
}