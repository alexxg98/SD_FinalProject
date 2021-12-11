using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject aboutMenu;
    public GameObject howtoMenu;

    public void OnAbout()
    {
        aboutMenu.SetActive(true);
    }
    public void OffAbout()
    {
        aboutMenu.SetActive(false);
    }

    public void OnHowTo()
    {
        howtoMenu.SetActive(true);
    }
    public void OffHowTo()
    {
        howtoMenu.SetActive(false);
    }
}
