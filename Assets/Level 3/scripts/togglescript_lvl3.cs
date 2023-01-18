using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togglescript_lvl3 : MonoBehaviour
{
    // toggle voor lvl3 , als rain aanstaat vermindert co2, vuur vergroot co2
    public int CO2 = 10;

    bool rainToggle;
     bool fireToggle;

    public void RainToggle(bool state)
    {
        rainToggle = state;
        if (state)
        {
            CO2 = CO2 - 10;
        }
        Debug.Log("rain is " + state + ". CO2 = " + CO2);
    }
    public void FireToggle(bool state)
    {
        fireToggle = state;
        if (state)
        {
            CO2 = CO2 + 10;
        }
        Debug.Log("fire is " + state + ". CO2 = " + CO2);
    }
}
