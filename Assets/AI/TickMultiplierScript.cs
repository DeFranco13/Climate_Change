using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class TickMultiplierScript : MonoBehaviour
{
    private Toggle toggle;
    public bool Loop = false;

    public void Start()
    {
        toggle = GetComponent<Toggle>();

        if (!Loop)
        {
            if (toggle.isOn) // Add if toggle default is on
                Do();

            toggle.onValueChanged.AddListener(delegate
            { // When toggle changes, add/remove multiplier
                if (toggle.isOn)
                    Do();
                else
                    Undo();
            });
        }
    }

    public void Update()
    {
        if(Loop)
        {
            if (toggle.isOn)
                Do();
            else
                Undo();
        }
    }

    abstract public void Do();

    abstract public void Undo();
}
