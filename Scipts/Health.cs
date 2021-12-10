using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    int hp = 30;

    void OnTriggerEnter2D(Collider2D other)
    {
        hp -= 10;
    }

    void Update()
    {
        CheckHealth();
        Debug.Log("Health = " + hp);
    }
    public void CheckHealth()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
