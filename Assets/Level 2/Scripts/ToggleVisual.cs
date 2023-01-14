using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleVisual : MonoBehaviour
{
    //Properties for the toggles
    public Toggle Windturbines;
    public Toggle Solarpanels;
    public Toggle Animals;
    public Toggle Cars;
    public Toggle Ind_Eq;

    GameObject turbines;
    GameObject solarpanel;
    GameObject animals;
    GameObject cars;
    GameObject ind_eq;
    
    void Start()
    {
        turbines = GameObject.FindGameObjectWithTag("Windmills");
        solarpanel = GameObject.FindGameObjectWithTag("Solarpanel");
        animals = GameObject.FindGameObjectWithTag("Animals");
        cars = GameObject.FindGameObjectWithTag("Cars");
        ind_eq = GameObject.FindGameObjectWithTag("Tractor");
        
    }

    void Update()
    {
        CheckToggle();
    }

    //Checks if a certain toggle is on, and if this is the case, it enables the corresponding gameobject
    private void CheckToggle()
    {
        if (Windturbines.isOn)
            turbines.SetActive(true);
        else
            turbines.SetActive(false);
        
        if (Solarpanels.isOn)
            solarpanel.SetActive(true);
        else
            solarpanel.SetActive(false);

        if (Animals.isOn)
            animals.SetActive(true);
        else
            animals.SetActive(false);

        if (Cars.isOn)
            cars.SetActive(true);
        else
            cars.SetActive(false);

        if (Ind_Eq.isOn)
            ind_eq.SetActive(true);
        else
            ind_eq.SetActive(false);
    }
}
