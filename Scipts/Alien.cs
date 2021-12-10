using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public static int hp = 30;
    public float speed = 2f;
    private Transform destination;
    private int wavePointIndex = 0;

    void Start()
    {
        destination = Waypoints.points[0];
    }
    void Update()
    {
        Vector3 dir = destination.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(transform.position, destination.position) <= 0.4f)
        {
            GetNextWayPoint();
        }
    }
    void GetNextWayPoint()
    {
        if (wavePointIndex >= Waypoints.points.Length - 1)
        {
            HomeBase.hp -= 10;
            Destroy(gameObject);
            return;

        }
        wavePointIndex++;
        destination = Waypoints.points[wavePointIndex];
        FindObjectOfType<LaneActivate>().Reset();
    }

}
