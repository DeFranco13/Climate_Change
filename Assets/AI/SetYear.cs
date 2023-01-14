using TMPro;
using UnityEngine;

public class SetYear : MonoBehaviour
{
    public string Prefix = "Year: "; // Prefix of textfield
    public int StartYear = 2023; // Start index which will be increased by current ticks
    private int lastTick; // Previous ticks to check if tick was updated
    private TMP_Text textField; // Year display textfield


    void Start() // Set textfield component
    {
        lastTick = 0;
        
        if (GetComponent<TextMeshProUGUI>() != null)
        {
            textField = GetComponent<TextMeshProUGUI>();
            textField.text = Prefix + StartYear;
        } 
    }

    void Update() // Update textfield with new tick value if it has changed
    {
        if(textField)
        {
            int nextTick = TickObject.instance.Ticks;
            if (nextTick >= lastTick)
            {
                lastTick = nextTick;
                textField.text = Prefix + (StartYear + lastTick);
            }
        }
    }
}
