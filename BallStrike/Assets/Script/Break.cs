using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collisionInf)
    {
        if(collisionInf.collider.tag == "Ball")
        {
            Debug.Log("ActiveBreak");
            Destroy(gameObject);
        }
    }
}
