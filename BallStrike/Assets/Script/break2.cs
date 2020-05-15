using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class break2 : MonoBehaviour
{
    public int cnt = 0;
    private void OnCollisionEnter2D(Collision2D collisionInf)
    {
        if (collisionInf.collider.tag == "Ball")
        {
            cnt++;
        }
        if(cnt==2)
        {
            Destroy(gameObject);
        }
    }
}
