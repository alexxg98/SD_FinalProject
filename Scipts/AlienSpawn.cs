using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawn : MonoBehaviour
{
    public GameObject alienPrefab;
    public static int randSpawn;
    // Start is called before the first frame update
    void Start()
    {
        randSpawn = Random.Range(8, 15);
        // Spawn first Alien after 6 secs, and every random secs afterwards
        InvokeRepeating("Spawn", 6, randSpawn);
        
    }

    void Spawn()
    {
        Instantiate(alienPrefab, transform.position, Quaternion.identity);
        
    }
}
