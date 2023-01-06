using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalRotating : MonoBehaviour
{
    private float random;
    private float time = 0;
    private float delay;

    private void Start()
    {
        delay = Random.Range(0.5f, 6);
    }
    // Update is called once per frame
    void Update()
    {
        time+= Time.deltaTime;
        if (time>delay)
        {
            random = Random.Range(5, 10);
            switch (random)
            {
                case 5:
                    transform.Rotate(0, 45, 0);
                    break;
                case 6:
                    transform.Rotate(0, -45, 0);
                    break;
                case 7:
                    transform.Rotate(0, 90, 0);
                    break;
                case 8:
                    transform.Rotate(0, -90, 0);
                    break;
                case 9:
                    transform.Rotate(0, 180, 0);
                    break;
                case 10:
                    transform.Rotate(0, -180, 0);
                    break;
                default:
                    break;
            }
            time = 0;
        }
    }
}
