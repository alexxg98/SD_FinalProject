using UnityEngine;

public class Beam : MonoBehaviour
{
    private Transform target;
    public float speed = 3f;
    int randSpawn;
    public GameObject coilPrefab;

    public void FindTarget(Transform target)
    {
        this.target = target;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }
    void HitTarget()
    {
        Destroy(gameObject, 0f);

        if (Alien.alienHP <= 0)
        {
            Destroy(target.gameObject);

            // Random chance of alien dropping coil object upon death
            if (GetRandomNum()%2==0) {
                //Debug.Log("rand#: " + randSpawn);
                GameObject coil = Instantiate(coilPrefab, transform.position, Quaternion.identity);
                Destroy(coil, 7); // Destroy coil if not collected after 7 secs
            }
            Alien.alienHP = 30;
        }
        else
        {
            Alien.alienHP -= 10;
        }

        //Debug.Log("Hit");
        // Debug.Log("Confirm #: " + AlienSpawn.randNum);
    }

    int GetRandomNum()
    {
        randSpawn = Random.Range(0, 10);
        //Debug.Log("Random Spawn Time: " + randSpawn);
        return randSpawn;
    }
}