using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TickTrigger : MonoBehaviour
{
    public int TriggerAt = 10;
    public TriggerOn trigger = TriggerOn.Ticks;
    public bool triggerOnce = false;
    private bool triggered = false;

    void Start() { }

    void Update()
    {
        if(trigger == TriggerOn.Ticks && (!triggerOnce && !triggered) && TickObject.instance.Ticks >= TriggerAt)
            OnTickTrigger();
        else if(trigger == TriggerOn.CO2 && (!triggerOnce && !triggered) && TickObject.instance.TotalCO2 >= TriggerAt)
            OnTickTrigger();
        else if (trigger == TriggerOn.Both && (!triggerOnce && !triggered) && TickObject.instance.Ticks >= TriggerAt && TickObject.instance.TotalCO2 >= TriggerAt)
            OnTickTrigger();
    }
    
    internal abstract void OnTickTrigger(); // Called when Ticks reach TriggerAt value
}

public enum TriggerOn
{
    Ticks,
    CO2,
    Both
}
