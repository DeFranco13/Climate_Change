using UnityEngine;

public class Ramp : TickMultiplier
{

    int trigger1 = 800;
    int trigger2 = 1000;
    int trigger3 = 1400;



    void rise1() {
        if (transform.position.y > -7.5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.01f, transform.position.z);
        }
    }

    void rise2()
    {
        if (transform.position.y > -7)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.01f, transform.position.z);
        }
    }

    void rise3()
    {
        if (transform.position.y < 3)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.01f, transform.position.z);
        }
    }

    
    

    // Update is called once per frame
    void Update()
    {
        if(trigger1 < TickObject.instance.TotalCO2 && trigger2 > TickObject.instance.TotalCO2){

            rise1();

        }else if (trigger2 < TickObject.instance.TotalCO2 && trigger3 > TickObject.instance.TotalCO2){

            rise2();

        }else if(trigger3 < TickObject.instance.TotalCO2){

            rise3();
        }
    }
}
