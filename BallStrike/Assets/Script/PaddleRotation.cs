using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleRotation : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    public float maxLeftRotation = 20.0f;
    public float maxRightRotation = 340.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation.eulerAngles.Set(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (Input.GetKey(KeyCode.Q) && Mathf.Abs(transform.rotation.eulerAngles.z - maxLeftRotation) >= 0.001f)
        //    transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        //if (Input.GetKey(KeyCode.E) && Mathf.Abs(transform.rotation.eulerAngles.z - maxRightRotation) >= 0.001f)
        //    transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime);

        if (Input.touchCount == 2 && Mathf.Abs(transform.rotation.eulerAngles.z - maxLeftRotation) >= 0.001f)
        {
            Touch zeroTouch = Input.GetTouch(0);
            float deltaDisplacement = zeroTouch.deltaPosition.y;
            transform.Rotate(Vector3.forward * deltaDisplacement * rotationSpeed * Time.deltaTime);
        }
    }
}
