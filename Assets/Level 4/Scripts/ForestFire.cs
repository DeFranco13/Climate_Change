using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestFire : TickMultiplierScript
{
    public GameObject fire;

    public void Start()
    {
        base.Start();
    }

    public override void Do()
    {
        fire.active = true;
    }

    public override void Undo()
    {
        fire.active = false;
    }
}
