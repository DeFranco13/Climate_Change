using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerObject : MonoBehaviour
{
    public float LowerBy = 5;
    public float LowerSpeed = 1;
    private float lowerTo;
    private float loweredBy;
    private bool atDestination;

    void Start()
    {
        lowerTo = gameObject.transform.position.y - LowerBy;
        loweredBy = 0;
        atDestination = false;
    }

    void Update()
    {
        if(!atDestination)
        {
            if (loweredBy < LowerBy)
            {
                float lower = LowerSpeed * Time.deltaTime;
                gameObject.transform.Translate(new Vector3(0, -lower, 0), Space.Self);
                loweredBy += lower;
            }
            else
            {
                atDestination = true;
                gameObject.transform.SetPositionAndRotation(new Vector3(gameObject.transform.position.x, lowerTo, gameObject.transform.position.z), gameObject.transform.rotation);
            }
        }
    }
}
