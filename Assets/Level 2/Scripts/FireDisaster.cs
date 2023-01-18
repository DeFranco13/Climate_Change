using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDisaster : TickTrigger
{
//Property for fire object
    public GameObject fire;

    internal override void OnTickTrigger()
    {
        Fire();
    }

    //method that enables the fire on the tree
    private void Fire()
    {
        if (TickObject.instance.TotalCO2>=1000)
        {
            fire.gameObject.SetActive(true);
        }
        else
        {
            fire.gameObject.SetActive(false);
        }
        
    }

}
