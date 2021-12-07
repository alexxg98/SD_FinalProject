using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public static GameObject robotPick;
    public static int robotCost;

    public string enemyTag = "Alien";
    private Transform target;

    public float range = 15f;
    public float beamRate = 1f;
    private float beamCoolDown = 0f;

    public GameObject beamPrefab;
    public Transform beamLocation;

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, .5f);
    }
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        if (nearestEnemy != null && shortestDistance <= range) target = nearestEnemy.transform;
        else target = null;
    }

    void Update()
    {
        if (target == null) return;
        if (beamCoolDown <= 0f)
        {
            ShootBeam();
            beamCoolDown = 1f/ beamRate; // reset back to beamRate
        }
        beamCoolDown -= Time.deltaTime;
    }

    void ShootBeam()
    {
        GameObject beamObj = (GameObject)Instantiate(beamPrefab, beamLocation.position, Quaternion.identity);
        Beam beam = beamObj.GetComponent<Beam>();

        if (beam != null)  beam.FindTarget(target);
        Debug.Log("Shoot!");
    }


}
