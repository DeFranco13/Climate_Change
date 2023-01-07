using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TickMultiplier : MonoBehaviour
{
    public float Multiplier = 1;
    public int CO2Addition = 0;
    private Toggle toggle;

    public void Start()
    {
        toggle = GetComponent<Toggle>();

        if (toggle.isOn) // Add if toggle default is on
            TickObject.instance.Multipliers.Add(Multiplier);

        toggle.onValueChanged.AddListener(delegate { // When toggle changes, add/remove multiplier
            if (toggle.isOn)
                add();
            else
                remove();
                
        });
    }

    private void add() // Add multiplier and CO2
    {
        TickObject.instance.CO2 += CO2Addition;
        TickObject.instance.Multipliers.Add(Multiplier);
    }

    private void remove()// Remove multiplier and CO2
    {
        TickObject.instance.CO2 -= CO2Addition;
        TickObject.instance.Multipliers.Remove(Multiplier);
    }
}
