using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TickMultiplier : MonoBehaviour
{
    public int CO2Addition = 0; // Addition to yearly CO2
    private Toggle toggle; // Current toggle

    public void Start() // Initialize properties and set listener on toggle
    {
        toggle = GetComponent<Toggle>();

        toggle.onValueChanged.AddListener(delegate { // When toggle changes, add/remove multiplier
            if (toggle.isOn)
                add();
            else
                remove();
                
        });
    }

    private void add() // Add CO2Addition to yearly CO2
    {
        TickObject.instance.YearlyCO2 += CO2Addition;
    }

    private void remove() // Remove CO2Addition to yearly CO2
    {
        TickObject.instance.YearlyCO2 -= CO2Addition;
    }
}
