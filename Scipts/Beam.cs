using UnityEngine;

public class Beam : MonoBehaviour
{
    private Transform target;
    public float speed = 3f;

    public void FindTarget(Transform target)
    {
        this.target = target;
    }

    void Update()
    {
        if(target == null)
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
        
        if (Alien.hp <= 0)
        {
            Destroy(target.gameObject);
            Alien.hp = 30;
        }
        else {
            Alien.hp -= 10;
        }
        
        Debug.Log("Hit");
        // Debug.Log("Confirm #: " + AlienSpawn.randNum);
    }
    
}
