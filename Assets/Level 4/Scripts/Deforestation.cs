using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deforestation : TickMultiplierScript
{
    public GameObject trees; // Parent object containing trees
    public override void Do() // Remove trees
    {
        trees.active = false;
    }

    public override void Undo() // Add trees
    {
        trees.active = true;
    } 
}
