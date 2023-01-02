using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLevel_2 : MonoBehaviour
{
    // Ticks CO2 INIT
    public int CO2 = 10;

    // Declareren van attributen
    bool solarToggle;
    bool busToggle;
    bool windTurbinesToggle;
    bool factoryToggle;
    bool oldCarsToggle;


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

    public void BusToggle(bool state) 
    {
        busToggle = state;
        if (state)
        {
            CO2 = CO2 - 1;
        }
        Debug.Log("Bus is " + state + ". CO2 = " + CO2);
    }
    public void WindTurbinesToggle(bool state)
    {
        windTurbinesToggle = state;
        if (state)
        {
            CO2 = CO2 - 2;
        }
        Debug.Log("Wind Turbines is " + state + ". CO2 = " + CO2);
    }
    public void FactoryToggle(bool state) 
    {
        factoryToggle = state;
        if (state)
        {
            CO2 = CO2 + 9;
        }
        Debug.Log("Factory is " + state + ". CO2 = " + CO2);
    }
    public void OldCarsToggle(bool state)
    {        
        oldCarsToggle = state;
        if (state)
        {
            CO2 = CO2 + 4;
        }
        Debug.Log("Old Cars is " + state + ". CO2 = " + CO2);
    }
    
}
