using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : TickTrigger
{
    public string DeathAnimator; // Animator with death animation
    internal override void OnTickTrigger() // Set animation to deathanimation and stop running if gameobject contains runningscript
    {
        if (GetComponent<Animator>() != null)
            GetComponent<Animator>().Play(DeathAnimator);
        if(GetComponent<MoveBackAndForth>() != null)
            GetComponent<MoveBackAndForth>().moving = false;
    }
}
