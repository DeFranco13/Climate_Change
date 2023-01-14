using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TickTrigger : MonoBehaviour
{
    public int TriggerAt = 10; // Value at which method gets triggered
    public TriggerOn trigger = TriggerOn.Ticks; // What to compare triggerat to
    public bool triggerOnce = false; // Whether or not trigger method is looped
    private bool triggered = false; // Wheter or not trigger method has been called

    void Start() { }

    void Update() // Call OnTickTrigger if TriggerAt is at trigger and 
    {
        if(trigger == TriggerOn.Ticks && (!triggerOnce || (triggerOnce && !triggered)) && TickObject.instance.Ticks >= TriggerAt)
            OnTickTrigger();
        else if(trigger == TriggerOn.CO2 && (!triggerOnce || (triggerOnce && !triggered)) && TickObject.instance.TotalCO2 >= TriggerAt)
            OnTickTrigger();
    }
    
    internal abstract void OnTickTrigger(); // Called when Ticks reach TriggerAt value
}

public enum TriggerOn
{
    Ticks,
    CO2,
}
