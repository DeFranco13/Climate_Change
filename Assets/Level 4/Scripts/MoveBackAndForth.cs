using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    private float startPosition;
    private float MoveToPosition;
    public Direction startDirection;
    private float direction;
    public float moveDistance = 10;
    public float Speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        if (startDirection == Direction.Right)
            direction = 1;
        else if(startDirection == Direction.Left)
            direction = -1;

        startPosition = gameObject.transform.position.z;
        MoveToPosition = gameObject.transform.position.z + (moveDistance * direction);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Speed * Time.deltaTime;
        gameObject.transform.Translate(new Vector3(0, 0, distance * direction), Space.Self);
        if (!isInBounds())
        {
            gameObject.transform.Rotate(new Vector3(0, 180, 0));
        }
    }

    private bool isInBounds()
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
