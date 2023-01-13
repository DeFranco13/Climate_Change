using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonLevel : MonoBehaviour
{

    
    bool pause = false;
    double Time = 1;
    double TimeCounter = 1;

    //Voor het spel te pauzeren wordt komende functie opgeroepen.
    public void ButtonPause()
    {
        if (pause)
        {
            //Play
            Debug.Log("State is: playing");
            pause = false;


        }
        else
        {
            //Pauze
            Debug.Log("State is: paused");

            pause = true; 
        }
    }
    //De Timer verhogen 
    public void ButtonDecrease()
    {
        Debug.Log("Decrease Time");
        TimeCounter--;
        UpdateTimer();
    }
    //De Timer verlagen
    public void ButtonIncrease()
    {
        Debug.Log("Increase Time");
        TimeCounter++;
        UpdateTimer();
    }

    // Controleren of de timer binnen de variatie in snelheden blijft anders wordt deze terug gestuurd nnaar laatste snelheid
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
