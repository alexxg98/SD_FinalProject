using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public static int alienHP = 30;
    public float speed = 2f;
    private Transform destination;
    private int wavePointIndex = 0;

    void Start()
    {
        destination = Waypoints.points[0];
    }
    void Update()
    {
        // Looking for points to traverse through
        Vector3 dir = destination.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(transform.position, destination.position) <= 0.2f)
        {
            GetNextWayPoint();
        }
    }
    void GetNextWayPoint()
    {
        // If alien reaches final wavepoint, destroy and inflict damage
        if (wavePointIndex >= Waypoints.points.Length - 1)
        {
            HomeBase.homebaseHP -= 10;
            HomeBase.CheckHealth();
            //Debug.Log("Health = " + HomeBase.homebaseHP);
            Destroy(gameObject);
            return;

        }
        wavePointIndex++;
        destination = Waypoints.points[wavePointIndex];
        
    }
}