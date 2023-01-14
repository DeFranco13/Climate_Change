using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestFire : TickMultiplierScript
{
    public GameObject fire; // Fire object

    public override void Do() // Enable fire
    {
        fire.active = true;
    }

    public override void Undo() // Disable fire
    {
        fire.active = false;
    }
}
