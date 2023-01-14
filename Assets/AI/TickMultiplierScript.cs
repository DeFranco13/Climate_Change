using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class TickMultiplierScript : MonoBehaviour
{
    private Toggle toggle; // Current toggle
    public bool Loop = false; // Wether to loop do and undo method

    public void Start() // Initialize properties and add listener to toggle
    {
        toggle = GetComponent<Toggle>();

        if (!Loop)
        {
            if (toggle.isOn)
                Do();

            toggle.onValueChanged.AddListener(delegate
            {
                if (toggle.isOn)
                    Do();
                else
                    Undo();
            });
        }
    }

    public void Update() // Call do or undo method every update if loop boolean is set to true
    {
        if(Loop)
        {
            if (toggle.isOn)
                Do();
            else
                Undo();
        }
    }

    abstract public void Do(); // Method to be executed when checkbox is toggled on

    abstract public void Undo(); // Method to be executed when checkbox is toggled off
}
