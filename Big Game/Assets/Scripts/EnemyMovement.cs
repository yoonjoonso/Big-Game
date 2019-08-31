﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    [SerializeField]
    private float interval = 1f;

    private float timer = 0f;
    
    private Vector2 dir = Vector2.zero;

    private Direction lastDirection = Direction.None;

    private int vertical = 1;
    private int horizontal = 2;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        timer += Time.fixedUnscaledDeltaTime;
        if (timer >= interval)
        {
            timer = 0f;
            GetDirection();
        }
    }

    private void GetDirection()
    {
        Vector2 dist = transform.position - target.position;

        int random = Random.Range(vertical,horizontal+1);
        if (random == 1)
        {
            if (dist.y > 0)
            {
                if (lastDirection != Direction.Up)
                {
                    Movement(Vector2.down);
                    lastDirection = Direction.Down;
                }
            }
            else
            {
                vertical = horizontal;
            }
        }
        else if (random == 2)
        {
            if (dist.x > 0)
            {
                if (lastDirection != Direction.Right)
                {
                    Movement(Vector2.left);
                    lastDirection = Direction.Left;
                }
            }
            else if(dist.x < 0)
            {
                if (lastDirection != Direction.Left)
                {
                    Movement(Vector2.right);
                    lastDirection = Direction.Right;
                }
            }
        }
    }

    private void Movement(Vector2 direction)
    {
        transform.Translate(direction);
    }
}
