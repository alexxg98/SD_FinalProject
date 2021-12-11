using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int hp = 30;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Alien"))
        hp -= 10;
        CheckHealth();
    }

    public void CheckHealth()
    {
        //Debug.Log("Health :" + hp);
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}