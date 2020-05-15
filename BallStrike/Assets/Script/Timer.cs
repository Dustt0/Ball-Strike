using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{

    float currentTime = 0f;
    [SerializeField] float startingTime = 3f;

    [SerializeField] Text countdownText;

    //public GameObject StartTimer;


    void Start()
    {
        Ball.FindObjectOfType<Ball>().cnt = 1;
        BatMove.FindObjectOfType<BatMove>().cnt = 1;
        
        currentTime = startingTime;

    }

    // Update is called once per frame
    void Update()
    {

        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");


        if (currentTime <= 0)
        {
            
            currentTime = 0;
            Ball.FindObjectOfType<Ball>().cnt = 0;
            BatMove.FindObjectOfType<BatMove>().cnt = 0;
            

        }
        if (currentTime <= 0)
        {
            FindObjectOfType<GameManager>().gameon();
            

        }
    }
}
