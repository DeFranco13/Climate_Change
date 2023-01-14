using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickObject : MonoBehaviour
{
    public static TickObject instance;

    private float ticks;
    public int Ticks {
        get { return (int)Mathf.Floor(ticks); }
    }
    public int CO2 = 100;
    public List<float> Multipliers = new List<float>();
    public float DefaultMultiplier = 0.1f;
    private int multiplierCount;
    private float multiplier;
    public bool paused = false;


    void Start()
    {
        if (instance != null && instance != this)
            Destroy(this);
        else
            instance = this;

        multiplierCount = 0;
        multiplier = 1f;
        CO2 = 100;
        Multipliers.Add(DefaultMultiplier);
    }


    void Update() // Add ticks to total
    {
        if(!paused)
        {
            setMultiplier();
            this.ticks += Time.deltaTime * multiplier;
        }
    }

    private void setMultiplier() // Set multiplier based on multipliers (from checkboxes)
    {
        multiplier = 1;
        Multipliers.ForEach(e => multiplier *= e);
        multiplierCount = Multipliers.Count;
    }
}
