using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public GameObject beamPrefab;
    private Transform target;

    public float range = 2f;
    public float beamRate = 2f;
    private float beamCoolDown = 0f;

    void Start()
    {
        // call FindTarget every second
        InvokeRepeating("FindTargets", 0f, 1f);
    }

    void Update()
    {
        // update keeps track of incoming targets
        if (target == null) return;
        if (beamCoolDown <= 0f)
        {
            ShootBeam();
            beamCoolDown = 1f / beamRate; // reset back to beamRate
        }
        beamCoolDown -= Time.deltaTime;
    }

    void FindTargets()
    {
        GameObject[] aliens = GameObject.FindGameObjectsWithTag("Alien");
        GameObject targetAlien = null;
        float closestTarget = Mathf.Infinity;
        // determine distance for all aliens within range
        foreach (GameObject alien in aliens)
        {
            float alienDistance = Vector3.Distance(transform.position, alien.transform.position);
            if (alienDistance <= closestTarget)
            {
                closestTarget = alienDistance;
                targetAlien = alien; // look on target when conditions met
            }
        }
        // lock on target if within range and target isn't null
        if (closestTarget <= range && targetAlien != null) target = targetAlien.transform;
        else target = null;
    }

    void ShootBeam()
    {
        GameObject beamObj = (GameObject)Instantiate(beamPrefab, transform.position, Quaternion.identity);
        Beam beam = beamObj.GetComponent<Beam>();
        if (beam != null) beam.FindTarget(target);
        //Debug.Log("Shoot!");
    }
}