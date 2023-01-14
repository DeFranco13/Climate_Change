using UnityEngine;

public class Ramp : TickMultiplier
{

    int trigger1 = 800;
    int trigger2 = 1000;
    int trigger3 = 1400;



    void rise1() { 
    
    }

    void rise2()
    {

    }

    void rise3()
    {

    }

    
    

    // Update is called once per frame
    void Update()
    {
        if(trigger1 <= TickObject.instance.TotalCO2 || trigger2 > TickObject.instance.TotalCO2){

            rise1();

        }else if (trigger2 <= TickObject.instance.TotalCO2 || trigger3 > TickObject.instance.TotalCO2){

            rise2();

        }else if(trigger3 <= TickObject.instance.TotalCO2){

            rise3();
        }
    }
}
