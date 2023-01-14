using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CropsDisaster : TickTrigger
{
    // Property for the crops
    public GameObject crops;
    public float delay = 0.1f;
    private float time;
    private void DestroyCrop()
    {
        time += Time.deltaTime;
        
        if (crops == null) return;
        if (!(time > delay)) return;
        time = 0;
        int crop = Random.Range(0, crops.transform.childCount);
        while(crops.transform.GetChild(crop)==null)
        {
            crop = Random.Range(0, crops.transform.childCount);
        }
        Destroy(crops.transform.GetChild(crop).gameObject);
    }

    internal override void OnTickTrigger()
    {
        Debug.Log(TickObject.instance.TotalCO2);
        DestroyCrop();
    }
}
