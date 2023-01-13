using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingWater : MonoBehaviour
{
    public float RisedBy = 5;
    public float RiseSpeed = 1;
    private float RiseTo;
    private float RiseBy;
    private bool atDestination;

    void Start()
    {
        RiseTo = gameObject.transform.position.y + RisedBy;
        RiseBy = 0;
        atDestination = false;
    }

    void Update()
    {
        if(!atDestination)
        {
            if (RiseBy < RisedBy)
            {
                float Higher = RiseSpeed * Time.deltaTime;
                gameObject.transform.Translate(new Vector3(0, +Higher, 0), Space.Self);
                RiseBy -= Higher;
            }
            else
            {
                atDestination = true;
                gameObject.transform.SetPositionAndRotation(new Vector3(gameObject.transform.position.x, RiseTo, gameObject.transform.position.z), gameObject.transform.rotation);
            }
        }
    }
}
