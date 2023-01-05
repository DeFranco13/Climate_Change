    using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetYear : MonoBehaviour
{
    public string Prefix = "Year: ";
    public int StartYear = 2022;
    private int lastTick;
    private TMP_Text textField;
    

    // Start is called before the first frame update
    void Start()
    {
        lastTick = 0;
        
        if (GetComponent<TextMeshProUGUI>() != null)
        {
            textField = GetComponent<TextMeshProUGUI>();
            textField.text = Prefix + StartYear;
        } 
    }

    // Update is called once per frame
    void Update()
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
