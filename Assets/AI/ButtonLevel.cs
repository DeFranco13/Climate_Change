using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonLevel : MonoBehaviour
{

    
    bool pause = false;
    double Time = 1;
    double TimeCounter = 1;

    public void ButtonPause()
    {
        if (pause)
        {

            Debug.Log("State is: playing");
            pause = false;


        }
        else
        {
            Debug.Log("State is: paused");

            pause = true; 
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
           
        }
        else if (TimeCounter == 1) {
            Time = 1;
            Debug.Log(Time);
            
        }
        else if (TimeCounter == 2) {
            Time = 2;
            Debug.Log(Time);
            
        }
        else if (TimeCounter == 3) {
            Time = 2.5;
            Debug.Log(Time);
            
        }
        else if (TimeCounter == 4)
        {
            Time = 5;
            Debug.Log(Time);

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
