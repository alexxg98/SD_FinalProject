using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectRobot : MonoBehaviour
{
    public GameObject robotPrefab;
    public static GameObject selectedRobot;
    public Button robot_button;
    public GameObject insignificantFundsCanvas;
    public GameObject selectCast;
    public static int robotCost;
    public static GameObject clickedCast;
    [SerializeField] int setCost;

    private void Start()
    {
        robot_button.onClick.AddListener(OnClickTask);
    }

    void OnClickTask()
    {
        // If sufficient funds, set selected robot as the prefab of button
        // Else show insufficient funds
        robotCost = setCost;

        if (EnergyCollect.energyTotal >= robotCost)
        {
            selectedRobot = robotPrefab;
            clickedCast = selectCast;
            clickedCast.SetActive(true);
            
            //Debug.Log("Robot Selected: " + selectedRobot);
            //Debug.Log("Robot Cost: " + robotCost);
        }
        else
        {
            insignificantFundsCanvas.SetActive(true);
            //Debug.Log("Insufficient Funds");
            StartCoroutine(WaitDisable(2)); // Wait 2 seconds before closing text
        }
    }

    private IEnumerator WaitDisable(float seconds)
    {
        //after a certain seconds, the text popup disappears
        yield return new WaitForSeconds(seconds);
        insignificantFundsCanvas.SetActive(false);
    }
}
