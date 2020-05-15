using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public int cnt = 0;
    public float maxHeight = -2.5f;
    public float minHeight = -5.0f;
    public float maxLeft = -1.73f;
    public float maxRight = 1.73f;
    public float error = 0.001f;
    public float specialError = 0.5f;
    

    void Start()
    {
        transform.position = new Vector3(0.0f, -4.0f, 0.0f);
        
    }

    // Update is called once per frame
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
    }

    private void OnMouseDrag()
    {
        if (cnt == 0)
        {
            if (transform.position.y <= maxHeight && transform.position.y >= minHeight && transform.position.x >= maxLeft && transform.position.x <= maxRight)
            {
                transform.position = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            }
        }
    }

    
}
