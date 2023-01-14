using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    float Speed = 0.05f;
    float move = 4.50f;
    public bool right = true;
    // < >


    // Wagen zal naar rechts bewegen omdat zijn z waarde wordt verhoogt
    void goRight()
    {
        Debug.Log("Go Right");
        transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + Speed);
    }

    // Wagen zal naar links bewegen omdat zijn z waarde wordt verhoogt
    void goLeft()
    {
        Debug.Log("Go Left");
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Speed);
    }



    // Elke frame wordt Update opgeroepen
    void Update()
    {

        // Boolean is true waardoor auto naar rechts beweegt
        if (right)
        {
            // Zolang z positie kleiner dan 100 is zal de auto naar rechts blijven gaan
            if (transform.position.z < 100)
            {
                goRight();
            }
            // Omdraaien van wagen door bereik
            else if (transform.position.z == 100 || transform.position.z > 100)
            {
                Debug.Log("Rotate");
                transform.Rotate(0, 180, 0);
                transform.position = new Vector3(transform.position.x - move, transform.position.y, transform.position.z);
                right = false;
            }
        } 
        // Boolean is false waardoor auto naar links
        else if (!right)
        {
            // Zolang de auto groter is dan -160 zal ze naar links blijven gaan
            if(transform.position.z > -160)
            {
                goLeft();
            }
            // Omdraaien van wagen door bereik
            else if (transform.position.z == -160 || transform.position.z < -160)
            {
                Debug.Log("Rotate");
                transform.Rotate(0, 180, 0);
                transform.position = new Vector3(transform.position.x + move, transform.position.y, transform.position.z);
                right = true;
            }
        }
    }
}
