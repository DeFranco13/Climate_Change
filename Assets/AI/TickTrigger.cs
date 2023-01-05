using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TickTrigger : MonoBehaviour
{
    public int TriggerAt = 10;
    private bool triggered = false;

    void Start() { }

    void Update()
    {
        if(!triggered && TickObject.instance.Ticks >= TriggerAt)
        {
            OnTickTrigger();
        }
    }
    
    internal abstract void OnTickTrigger();
}
