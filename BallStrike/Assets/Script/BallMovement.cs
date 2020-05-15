using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float moveSpeed = 8f;
    //public Vector2 startDirection;
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 startDirection = GetRandomDirection();
        rb.velocity = moveSpeed * startDirection;
    }

    private Vector2 GetRandomDirection()
    {
        int xDir = Random.Range(0, 2);
        xDir = xDir == 0 ? -1 : 1;
        float yDir = Random.Range(-1f, 1f);
        return new Vector2(xDir, yDir);
    }

  
}
