using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum Direction { None =0, Up, Down, Left, Right, }

public class HeadMovement : MonoBehaviour
{
    [SerializeField]
    private Transform target = null;

    [SerializeField]
    private float interval = 60f;

    [SerializeField]
    private Vector3 moveDirection = Vector3.down;

    [SerializeField]
    private Direction lastDirection = Direction.None;

    [SerializeField]
    private List<Transform> tailTransforms = new List<Transform>();

    public List<Transform> TailTransforms
    {
        get
        {
            return tailTransforms;
        }

        set
        {
            tailTransforms = value;
        }
    }

    private void Awake()
    {
        moveDirection = Vector2.down;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoroutineUpdate());
    }

    // Update is called once per frame
    public IEnumerator CoroutineUpdate()
    {
        while (true)
        {
            for (int _indx = 0; _indx <= interval; _indx++)
            {
                yield return new WaitForEndOfFrame();
            }
            moveDirection = GetDirection();
            Vector3 lastPosition = transform.position;
            transform.position += moveDirection * .3f;

            //Vector3 tempPos = tailTransforms[0].transform.position;
            //tailTransforms[0].transform.position = lastPosition;
            for (int _indx = 0; _indx < tailTransforms.Count;_indx++)
            {
                Vector3 tempPos = lastPosition;
                lastPosition = tailTransforms[_indx].transform.position;
                tailTransforms[_indx].transform.position = tempPos;
            }
        }
    }

    Vector3 GetDirection()
    {
        Vector2 randomDirection = Vector2.zero;
        Direction dir = RandomDirectionValue();

        if(dir == Direction.Down)
        {
            lastDirection = Direction.Down;
            randomDirection = Vector2.down;
        }
        else
        {
            if (dir == Direction.Right && lastDirection != Direction.Left)
            {
                lastDirection = Direction.Right;
                randomDirection = Vector2.right;
            }
            else if (dir == Direction.Left && lastDirection != Direction.Right)
            {
                lastDirection = Direction.Left;
                randomDirection = Vector2.left;
            }
            else
            {
                lastDirection = Direction.Down;
                randomDirection = Vector2.down;
            }
        }

        return randomDirection;
    }

    Direction RandomDirectionValue()
    {
        Direction direction;
        Array values = Enum.GetValues(typeof(Direction));
        direction = (Direction) values.GetValue(UnityEngine.Random.Range(2, values.Length));
        return direction;
    }
}
