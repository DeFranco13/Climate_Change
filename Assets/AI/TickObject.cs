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
    public int CO2;
    public List<float> Multipliers = new List<float>();
    public float DefaultMultiplier = 0.1f;
    private int multiplierCount;
    private float multiplier;


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


    void Update()
    {
        setMultiplier();
        this.ticks += Time.deltaTime * multiplier;
        Debug.Log(Ticks + " / " + CO2);
    }

    private void setMultiplier()
    {
        multiplier = 1;
        Multipliers.ForEach(e => multiplier *= e);
        multiplierCount = Multipliers.Count;
    }
}
