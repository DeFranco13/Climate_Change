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

        if (toggle.isOn) // ADD IF TOGGLE DEFAULT IS ON
            TickObject.instance.Multipliers.Add(Multiplier);

        toggle.onValueChanged.AddListener(delegate { // WHEN TOGGLE CHANGES, ADD/REMOVE MULTIPLIER
            if (toggle.isOn)
                add();
            else
                remove();
                
        });
    }

    private void add()
    {
        TickObject.instance.CO2 += CO2Addition;
        TickObject.instance.Multipliers.Add(Multiplier);
    }

    private void remove()
    {
        TickObject.instance.CO2 -= CO2Addition;
        TickObject.instance.Multipliers.Remove(Multiplier);
    }
}
