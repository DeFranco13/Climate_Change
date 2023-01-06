using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLevel_2 : MonoBehaviour
{
    // Ticks CO2 INIT
    public int CO2 = 10;

    // Declareren van attributen
    bool solarToggle;
    bool tractorToggle;
    bool windTurbinesToggle;
    bool carsToggle;
    bool cowsToggle;


    // Methodes voor Toggle aan te zetten
    public void SolarToggle(bool state)
    {
        solarToggle = state;
        if (state)
        {
            CO2 = CO2 -3;
        }
        Debug.Log("Solar is " + state + ". CO2 = " + CO2);
    }

    public void TractorToggle(bool state) 
    {
        tractorToggle = state;
        if (state)
        {
            CO2 = CO2 + 4;
        }
        Debug.Log("Tractor is " + state + ". CO2 = " + CO2);
    }
    public void WindTurbinesToggle(bool state)
    {
        windTurbinesToggle = state;
        if (state)
        {
            CO2 = CO2 - 4;
        }
        Debug.Log("Wind Turbines are " + state + ". CO2 = " + CO2);
    }
    public void CarsToggle(bool state) 
    {
        carsToggle = state;
        if (state)
        {
            CO2 = CO2 + 7;
        }
        Debug.Log("cars are " + state + ". CO2 = " + CO2);
    }
    public void CowsToggle(bool state)
    {        
        cowsToggle = state;
        if (state)
        {
            CO2 = CO2 + 2;
        }
        Debug.Log("Cows are " + state + ". CO2 = " + CO2);
    }
    
}
