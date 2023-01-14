using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Migrate : TickTrigger
{
    public int distance; // Distance to move gameobject
    private float distanceMoved; // Distance moved
    public int speed; // Speed of gameobject movement
    internal override void OnTickTrigger() // Start moving birds up until they reach distance
    {
        if(distanceMoved < distance) {
            float currentdistance = speed * Time.deltaTime;
            gameObject.transform.Translate(new Vector3(0, currentdistance, 0));
            distanceMoved += currentdistance;
        }
    }
}
