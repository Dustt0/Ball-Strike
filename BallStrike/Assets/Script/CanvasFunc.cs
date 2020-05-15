using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFunc : MonoBehaviour
{
    public bool isPause = false;
    // Start is called before the first frame update
    
    
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
   


}
