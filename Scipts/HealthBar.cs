using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Image HealthBarImg;

    private void Start()
    {
        HealthBarImg.fillAmount = 1; // for restart
    }

    private void Update()
    {
        SetHealthBarValue();
        if (GameManager.gameOver == true)
        {
            HomeBase.homebaseHP = 100;
            HealthBarImg.fillAmount = 1; // for restart
        }
    }

    void SetHealthBarValue()
    {
        // value needs to be between 0 and 1
        float value = HomeBase.homebaseHP / 100f;
        //Debug.Log(value);
        HealthBarImg.fillAmount = value;
    }
}
