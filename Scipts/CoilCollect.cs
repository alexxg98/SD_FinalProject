using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoilCollect : MonoBehaviour
{
    public static int coilCollection;

    private void OnMouseDown()
    {
        // Collect Energy
        coilCollection += 1;
        //Debug.Log("Coil #: " + coilCollection);

        // Destroy Energy object after collecting # of coils
        Destroy(gameObject);
        if (coilCollection >= 5)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
