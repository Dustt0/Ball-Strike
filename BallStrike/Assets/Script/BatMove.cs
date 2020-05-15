using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMove : MonoBehaviour
{
    // Range option so moveSpeedModifier can be modified in Inspector
    // this variable helps to simulate objects acceleration
    //[Range(0.2f, 2f)]
    //public float moveSpeedModifier = 0.5f;

    // Direction variables that read acceleration input to be added
    // as velocity to Rigidbody2d component
    //float dirX, dirY;


    public float maxHeight = -1.5f;
    public float minHeight = -4f;
    public float maxLeft = -1.73f;
    public float maxRight = 1.73f;
    public float error = 0.001f;
    public float specialError = 0.5f;

    public int cnt = 0;
    //Rigidbody2D rb;
    //protected Joystick joystick;
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        if (transform.position.y >= maxHeight)
            transform.position = new Vector3(transform.position.x, maxHeight - error);
        if (transform.position.y <= minHeight)
            transform.position = new Vector3(transform.position.x, minHeight + specialError);
        if (transform.position.x >= maxRight)
            transform.position = new Vector3(maxRight - error, transform.position.y);
        if (transform.position.x <= maxLeft)
            transform.position = new Vector3(maxLeft + error, transform.position.y);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0.0f);

        // Getting devices accelerometer data in X and Y direction
        // multiplied by move speed modifier
        //dirX = Input.acceleration.x * moveSpeedModifier;
        //dirY = Input.acceleration.y * moveSpeedModifier;


        //if (cnt == 0)
        //{
        //    joystick = FindObjectOfType<Joystick>();
        //    rb.velocity = new Vector2(joystick.Horizontal * 8f, joystick.Vertical * 8f);
        //}
    }

    private void FixedUpdate()
    {
        if (cnt == 0)
        {
            if (transform.position.y <= maxHeight && transform.position.y >= minHeight && transform.position.x >= maxLeft && transform.position.x <= maxRight)
            { 
                //rb.velocity = new Vector2(rb.velocity.x + dirX, rb.velocity.y + dirY);
                transform.Translate(Input.acceleration.x, Input.acceleration.y, 0);
            }
            
        }
    }
}
