using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draught : TickMultiplierScript
{
    public GameObject WaterPlane;
    private int distance = 100;

    public override void Do()
    {
        WaterPlane.transform.Translate(new Vector3(0, -distance, 0), Space.Self);
        WaterPlane.GetComponent<AudioSource>().mute = true;
    }

    public override void Undo()
    {
        WaterPlane.transform.Translate(new Vector3(0, distance, 0), Space.Self);
        WaterPlane.GetComponent<AudioSource>().mute = false;
    }
}
