using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    int hp = 5;

    public void DoDamage(int damage)
    {
        hp -= damage;

        // Destroy if lose all health (died)
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
