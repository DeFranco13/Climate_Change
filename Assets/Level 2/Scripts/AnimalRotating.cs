using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalRotating : MonoBehaviour
{
    //Properties
    private float random;
    private float time = 0;
    private float delay;

    private void Start()
    {
        //a random delay before animal turns again
        delay = Random.Range(0.5f, 6);
    }

    void Update()
    {
        Turn();
    }

    //When the time delay has been passed, the object will turn in a random direction
    private void Turn()
    {
        time += Time.deltaTime;
        if (time > delay)
        {
            random = Random.Range(-180, 180);
            transform.Rotate(0, random,0);
            time = 0;
        }
    }
}
