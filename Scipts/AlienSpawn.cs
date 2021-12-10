using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawn : MonoBehaviour
{
    public int randSpawn;
    public GameObject alienPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //randSpawn = GetRandomNum();
        // Debug.Log("Random Spawn Time: " + randSpawn);
        // Spawn first Alien after 6 secs, and every random secs afterwards
        //InvokeRepeating("Spawn", 6, randSpawn);
        Invoke("Spawn", GetRandomNum());
    }

    void Spawn()
    {
        FindObjectOfType<LaneActivate>().RandComp();
        Instantiate(alienPrefab, transform.position, Quaternion.identity);
        Invoke("Spawn", GetRandomNum());
    }

    int GetRandomNum()
    {
        randSpawn = Random.Range(5, 15);
        Debug.Log("Random Spawn Time: " + randSpawn);
        return randSpawn; 
    }
}