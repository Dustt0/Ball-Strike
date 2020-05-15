using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{

    float currentTime = 0f;
   [SerializeField] float startTime = 61f;
    [SerializeField] Text Text;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        currentTime = startTime;
        Text.text = "00 : 00";
    }

    // Update is called once per frame
    void Update()
    {

        currentTime -= 1 * Time.deltaTime;
        string Minute = Mathf.Floor((currentTime % 3600) / 60).ToString("00");
        string second = (currentTime % 60).ToString("00");
        Text.text = Minute + " : " + second;

        //Text.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            Text.text = "00 : 00";
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
