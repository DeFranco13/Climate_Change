using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDisaster : TickTrigger
{
    public GameObject fire;

    internal override void OnTickTrigger()
    {
        Fire();
    }

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
