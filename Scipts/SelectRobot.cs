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
    public static int robotCost;
    [SerializeField] int setCost;

    private void Start()
    {
        robot_button.onClick.AddListener(OnClickTask);
    }

    void OnClickTask()
    {
        if (EnergyCollect.energyTotal >= robotCost)
        {
            selectedRobot = robotPrefab;
            robotCost = setCost;
            Debug.Log("Robot Slected: " + selectedRobot);
        }
        else
        {
            insignificantFundsCanvas.SetActive(true);
            Debug.Log("Insufficient Funds");
            StartCoroutine(WaitDisable(2));
        }
    }

    private IEnumerator WaitDisable(float seconds)
    {
        //after a certain seconds, the text popup disappears
        yield return new WaitForSeconds(seconds);
        insignificantFundsCanvas.SetActive(false);
    }
}
