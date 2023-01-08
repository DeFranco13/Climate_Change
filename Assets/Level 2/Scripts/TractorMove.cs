using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorMove : MonoBehaviour
{
    public float Speed = 0.04f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x<710)
        {
            transform.Rotate(0, 180, 0);
            Speed *= -1;
        } else if (transform.position.x > 880)
        {
            transform.Rotate(0, 180, 0);
            Speed *= -1;
        }
        transform.position = new Vector3(transform.position.x - Speed, transform.position.y, transform.position.z);
    }
}
