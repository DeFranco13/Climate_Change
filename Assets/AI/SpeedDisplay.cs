using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpeedDisplay : MonoBehaviour
{
    public List<float> SpeedOptions = new List<float>();
    public Button BackwardButton;
    public Button ForwardButton;
    public int DefaultSpeedIndex = 0;
    private int currentSpeedIndex = 0;
    private TMP_Text textField;

    // Start is called before the first frame update
    void Start()
    {
        textField = GetComponent<TextMeshProUGUI>();
        currentSpeedIndex = DefaultSpeedIndex;
        TickObject.instance.Multipliers.Add(SpeedOptions[currentSpeedIndex]);
        setSpeedText();
        
        // Set listener on backbutton if it exists
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

        // Set listener on forwardbutton if it exists
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

    private void setSpeedText() // Set textfield
    {
        if(textField != null)
        {
            textField.text = $"Speed: {SpeedOptions[currentSpeedIndex]}X";
        }
    }
}
