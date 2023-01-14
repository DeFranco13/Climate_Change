using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TickObject : MonoBehaviour
{
    public static TickObject instance; // Current TickObject instance (singleton)

    private float ticks; // Current ticks
    public int Ticks {
        get { return (int)Mathf.Floor(ticks); }
    }
    private int previousTicks; // Previous ticks

    public int TotalCO2 = 500; // Total amount of CO2
    public int YearlyCO2 = 10; // Yearly addition of CO2 to total
    public int GameOverCO2 = 1000; // Game over occurs at this CO2 amount

    public List<float> Multipliers = new List<float>(); // Current list of multipliers
    public float DefaultMultiplier = 0.1f; // Default speed multiplier
    private float multiplier; // Current multiplier

    public bool Paused = false; // Wether ticks are paused or not


    void Start() // Initialize parameters and set multipliers
    {
        if (instance != null && instance != this)
            Destroy(this);
        else
            instance = this;

        setMultiplier();
        Multipliers.Add(DefaultMultiplier);
        this.previousTicks = this.Ticks;
    }


    void Update() // Add ticks to total if game is not paussed and check if TotalCO2 higher than GameOverCO2
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
                SceneManager.LoadScene("EndScreen");
            }
        }
    }

    private void setMultiplier() // Set multiplier based on multipliers (from checkboxes)
    {
        multiplier = 1;
        Multipliers.ForEach(e => multiplier *= e);
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("score", 2023+Ticks);
    }
}
