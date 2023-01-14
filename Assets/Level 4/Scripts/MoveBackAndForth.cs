using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    private float startPosition; // Start position of gameobject
    private float MoveToPosition; // Destination of gameobject
    public Direction startDirection; // Start direction to move gameobject in
    private float direction; // Current moving direction
    public float moveDistance = 10; // Distance between start position and destination position
    public float Speed = 1; // Speed to move gameobject
    public bool moving = true; // Whether or not gameobject is moving

    void Start() // Initialize variables
    {
        if (startDirection == Direction.Right)
            direction = 1;
        else if(startDirection == Direction.Left)
            direction = -1;

        startPosition = gameObject.transform.position.z;
        MoveToPosition = gameObject.transform.position.z + (moveDistance * direction);
    }

    void Update() // Move gameobject and check if at destination. If so, rotate 
    {
        if(moving)
        {
            float distance = Speed * Time.deltaTime;
            gameObject.transform.Translate(new Vector3(0, 0, distance * direction), Space.Self);
            if (!isInBounds())
            {
                gameObject.transform.Translate(new Vector3(0, 0, -distance * direction), Space.Self);
                gameObject.transform.Rotate(new Vector3(0, 180, 0));
            }
        }
    }

    private bool isInBounds() //Check if gameobject is still between startposition and destination
    {
        if (startDirection == Direction.Left)
        {
            if (gameObject.transform.position.z > MoveToPosition && gameObject.transform.position.z < startPosition)
                return true;
        }
        else
        {
            if (gameObject.transform.position.z < MoveToPosition && gameObject.transform.position.z > startPosition)
                return true;
        }
        return false;
    }


    public enum Direction
    {
        Left,
        Right
    }
}
