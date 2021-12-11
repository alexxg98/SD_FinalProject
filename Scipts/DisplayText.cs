using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayText : MonoBehaviour
{
    public TextMeshProUGUI energyText;
    public TextMeshProUGUI coilText;

    // Start is called before the first frame update
    void Start()
    {
        // Player starts with 50 Enery, 0 Coil
        EnergyCollect.energyTotal = 50;
        CoilCollect.coilCollection = 0;
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        energyText.text = EnergyCollect.energyTotal + "";
        coilText.text = CoilCollect.coilCollection + "";
    }
}
