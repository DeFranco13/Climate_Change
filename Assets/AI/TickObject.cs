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
    private int previousTicks;

    public int TotalCO2 = 500;
    public int YearlyCO2 = 10;
    public int GameOverCO2 = 1000;

    public List<float> Multipliers = new List<float>();
    public float DefaultMultiplier = 0.1f;
    private float multiplier;

    public bool Paused = false;


    void Start()
    {
        if (instance != null && instance != this)
            Destroy(this);
        else
            instance = this;

        setMultiplier();
        Multipliers.Add(DefaultMultiplier);
        this.previousTicks = this.Ticks;
    }


    void Update() // Add ticks to total
    {
        if(!Paused)
        {
            setMultiplier();
            this.ticks += Time.deltaTime * multiplier;
            if(previousTicks != this.Ticks)
            {
                previousTicks = this.Ticks;
                this.TotalCO2 += this.YearlyCO2;
            }


            if (this.TotalCO2 >= this.GameOverCO2)
            {
                this.Paused = true;
                //SHOW END SCREEN
            }
        }
    }

    private void setMultiplier() // Set multiplier based on multipliers (from checkboxes)
    {
        multiplier = 1;
        Multipliers.ForEach(e => multiplier *= e);
    }
}
