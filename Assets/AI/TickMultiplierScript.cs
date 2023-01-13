using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class TickMultiplierScript : MonoBehaviour
{
    private Toggle toggle;

    public void Start()
    {
        toggle = GetComponent<Toggle>();

        if (toggle.isOn) // Add if toggle default is on
            Do();

        toggle.onValueChanged.AddListener(delegate { // When toggle changes, add/remove multiplier
            if (toggle.isOn)
                Do();
            else
                Undo();
                
        });
    }

    virtual public void Do() { }

    virtual public void Undo() { }
}
