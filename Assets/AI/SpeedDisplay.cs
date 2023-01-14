using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpeedDisplay : MonoBehaviour
{
    public List<float> SpeedOptions = new List<float>(); // Time speed options
    public Button BackwardButton; // Button to slow down time
    public Button ForwardButton; // Button to speed up time
    public int DefaultSpeedIndex = 0; // Index of default time
    private int currentSpeedIndex = 0; // Current index of time
    private TMP_Text textField; // Textfield for displaying the current time
    public string TextfieldPrefix; // Prefix for textfield
    public string TextfieldSuffix; // Suffix for textfield

    void Start() // Initialize properties and set listeners on updates
    {
        textField = GetComponent<TextMeshProUGUI>();
        currentSpeedIndex = DefaultSpeedIndex;
        TickObject.instance.Multipliers.Add(SpeedOptions[currentSpeedIndex]);
        setSpeedText();
        
        if (BackwardButton != null)
        {
            BackwardButton.onClick.AddListener(() =>
            {
                if (currentSpeedIndex > 0)
                {
                    TickObject.instance.Multipliers.Remove(SpeedOptions[currentSpeedIndex]);
                    currentSpeedIndex--;
                    TickObject.instance.Multipliers.Add(SpeedOptions[currentSpeedIndex]);
                    setSpeedText();
                }
            });
        }

        if (ForwardButton != null)
        {
            ForwardButton.onClick.AddListener(() =>
            {
                if (currentSpeedIndex < SpeedOptions.Count-1)
                {
                    TickObject.instance.Multipliers.Remove(SpeedOptions[currentSpeedIndex]);
                    currentSpeedIndex++;
                    TickObject.instance.Multipliers.Add(SpeedOptions[currentSpeedIndex]);
                    setSpeedText();
                }
            });
        }
    }

    private void setSpeedText() // Set textfield with current speed
    {
        if(textField != null)
        {
            textField.text = $"{this.TextfieldPrefix}{SpeedOptions[currentSpeedIndex]}{this.TextfieldSuffix}";
        }
    }
}
