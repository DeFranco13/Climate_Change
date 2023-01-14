using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Draught : TickMultiplierScript
{
    public GameObject WaterPlane;
    public int Distance = 100;
    public float Speed = 0.1f;
    private float lowerTo;
    private float loweredBy;
    private bool atDestination;
    private Vector3 startPosition;

    public void Start()
    {
        lowerTo = WaterPlane.transform.position.y - Distance;
        loweredBy = 0;
        atDestination = false;
        startPosition = WaterPlane.transform.position;
        base.Start();
    }

    public override void Do()
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

    public override void Undo()
    {
        WaterPlane.transform.position = startPosition;
        WaterPlane.GetComponent<AudioSource>().mute = false;

        lowerTo = WaterPlane.transform.position.y - Distance;
        loweredBy = 0;
        atDestination = false;
        startPosition = WaterPlane.transform.position;
    }
}
