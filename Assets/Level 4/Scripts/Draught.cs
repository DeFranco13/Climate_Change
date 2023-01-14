using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Draught : TickMultiplierScript
{
    public GameObject WaterPlane; // Gameobject to lower
    public int Distance = 100; // Distance of gameobject destination
    public float Speed = 0.1f; // Speed of lowering the gameobject
    private float lowerTo; // Where to lower gameobject to
    private float loweredBy; // Amount the gameobject is lowered by
    private bool atDestination; // Whether or not gameobject is at destination
    private Vector3 startPosition; // Original position of gameobject

    public void Start() // Initialize variables
    {
        lowerTo = WaterPlane.transform.position.y - Distance;
        loweredBy = 0;
        atDestination = false;
        startPosition = WaterPlane.transform.position;
        base.Start();
    }

    public override void Do() // Lower water until no longer visible and mute audio
    {
        if (!atDestination)
        {
            if (loweredBy < Distance)
            {
                float lower = Speed * Time.deltaTime;
                WaterPlane.transform.Translate(new Vector3(0, -lower, 0), Space.Self);
                loweredBy += lower;
            }
            else
            {
                atDestination = true;
                WaterPlane.transform.SetPositionAndRotation(new Vector3(WaterPlane.transform.position.x, lowerTo, gameObject.transform.position.z), gameObject.transform.rotation);
                WaterPlane.GetComponent<AudioSource>().mute = true;
            }
        }
    }

    public override void Undo() // Return water to startposition and play audio again
    {
        WaterPlane.transform.position = startPosition;
        WaterPlane.GetComponent<AudioSource>().mute = false;

        lowerTo = WaterPlane.transform.position.y - Distance;
        loweredBy = 0;
        atDestination = false;
        startPosition = WaterPlane.transform.position;
    }
}
