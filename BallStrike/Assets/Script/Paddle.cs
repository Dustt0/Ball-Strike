using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;
    public float rightscreenedge;
    public float topscreen;
    public float bottomscreen;
    public float leftscreenedge;
    public float velocidade;
    public float rotSpeed = 90f;
    //bool rotLeft, rotRight, rotCentre;

    //float touchPosX;
    //int moveInput;

    //Vector3 startpoint;
    //Vector3 endpoint;

    public Camera mainCamera;
    public float paddleInitialY;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
        paddleInitialY = this.transform.position.y;
    }

    // Update is called once per frame

    public void PaddleMovement()
    {
        if (Input.GetMouseButton(0))
        {
            float mousePositionWorldX = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 0)).x;
            this.transform.position = new Vector3(mousePositionWorldX, paddleInitialY, 0);
        }
    }


    void Update()
    {
        PaddleMovement();

    }
}

