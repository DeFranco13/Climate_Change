using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDead : MonoBehaviour
{
    public float DropTo = 0;
    public float DropSpeed = 1;
    private bool onFloor = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Rotate(new Vector3(0, 0, -90), Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        if(!onFloor)
        {
            if (gameObject.transform.position.y > DropTo)
                gameObject.transform.Translate(new Vector3(DropSpeed * Time.deltaTime, 0, 0));
            else
            {
                onFloor = true;
                gameObject.transform.SetPositionAndRotation(new Vector3(gameObject.transform.position.x, DropTo, gameObject.transform.position.z), gameObject.transform.rotation);
            }
        }
    }
}
