using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLevel : MonoBehaviour
{
    public Text text;

    bool isPaused = false;
    double Time = 1;
    double TimeCounter = 1;

    public void ButtonPause()
    {
        isPaused = true;
        if (isPaused)
        {
            Debug.Log("Pauze menu is true!");
            // Screen pauzeren en ticks
            isPaused = false;
        }
    }

    public void ButtonDecrease()
    {
        Debug.Log("Decrease Time");
        TimeCounter--;
        UpdateTimer();
    }
    public void ButtonIncrease()
    {
        Debug.Log("Increase Time");
        TimeCounter++;
        UpdateTimer();
    }
    void UpdateTimer() {
        if (TimeCounter == 0) {
            Time = 0.5;
            Debug.Log(Time);
           // text.text = "Time: 0.5x";
        }
        else if (TimeCounter == 1) {
            Time = 1;
            Debug.Log(Time);
            // text.text = "Time: 1x";
        }
        else if (TimeCounter == 2) {
            Time = 2;
            Debug.Log(Time);
            // text.text = "Time: 2x";
        }
        else if (TimeCounter == 3) {
            Time = 5;
            Debug.Log(Time);
            // text.text = "Time: 5x";
        }
        else if (TimeCounter == 4) {
            Time = 10;
            Debug.Log(Time);
            // text.text = "Time: 10x";
        }
        else if (TimeCounter > 4) {
            TimeCounter = 4;
            Debug.Log(Time);

        }
        else if (TimeCounter < 0) {
            TimeCounter = 0;
            Debug.Log(Time);

        }
    }
    

    
}
