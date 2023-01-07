using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestFire : TickMultiplierScript
{
    // Start is called before the first frame update
    
    public override void Do()
    {
        Debug.Log("DO");
        base.Do();
    }

    public override void Undo()
    {
        Debug.Log("UNDO");
        base.Undo();
    }
}
