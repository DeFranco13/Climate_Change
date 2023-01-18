using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateRain : TickMultiplierScript
{
    
    public GameObject rain;
    
   
    public void Start()
    {
        base.Start();
    }
    // als toggle aangeduid is = start regen
    [System.Obsolete]
    public override void Do()
    {
        rain.active = true;
        
    }
    // als toggle uitgezet is = stop regen
    [System.Obsolete]
    public override void Undo()
    {
        rain.active = false;
        
    }

    [System.Obsolete]
    public  bool IsOn()
    {
        if (rain.active)
        {
            return true;
        }
        return false;
    }
}
