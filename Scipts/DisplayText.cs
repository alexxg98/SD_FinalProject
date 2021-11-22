using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayText : MonoBehaviour
{
    public TextMeshProUGUI energyText;

    // Start is called before the first frame update
    void Start()
    {
        // Player starts with 50 Enery
        EnergyCollect.energyTotal = 50;
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
    }
}
