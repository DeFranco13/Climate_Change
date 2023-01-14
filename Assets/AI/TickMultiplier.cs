using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TickMultiplier : MonoBehaviour
{
    public int CO2Addition = 0;
    private Toggle toggle;

    public void Start()
    {
        toggle = GetComponent<Toggle>();

        toggle.onValueChanged.AddListener(delegate { // When toggle changes, add/remove multiplier
            if (toggle.isOn)
                add();
            else
                remove();
                
        });
    }

    private void add() // Add multiplier and CO2
    {
        TickObject.instance.YearlyCO2 += CO2Addition;
    }

    private void remove()// Remove multiplier and CO2
    {
        TickObject.instance.YearlyCO2 -= CO2Addition;
    }
}
