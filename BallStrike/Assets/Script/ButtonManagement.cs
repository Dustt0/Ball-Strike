using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManagement : MonoBehaviour
{
    public GameObject paddle;
    public float rotationSpeed = 100.0f;
    public float maxLeftRotation = 20.0f;
    public float maxRightRotation = 340.0f;

    public void LeftManagement()
    { 
        if (Mathf.Abs(paddle.transform.rotation.eulerAngles.z - maxLeftRotation) >= 2.001f)
            paddle.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    public void RightManagement()
    {
        if (Mathf.Abs(paddle.transform.rotation.eulerAngles.z - maxRightRotation) >= 2.001f)
            paddle.transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
