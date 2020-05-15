using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject beginTimer;
    public GameObject InGameTime;

   public int cnt = 0;
    
    public int scr;
    public Text scoreText;

    void Start()
    {
        
        scoreText.text = "Score: " + scr + "/30";
    }

    public void UpdateScore()
    {
        


        scr += 1;
        scoreText.text = "Score: " + scr + "/30";
        

        if(scr==20 && cnt==0)
        {
            SceneManager.LoadScene("Level 2");
            
            
        }
        if(scr==18 && cnt==1)
        {
            SceneManager.LoadScene("Level 3");
            
        }
        if(scr==15 && cnt==2)
        {
            SceneManager.LoadScene("ThankYou");
        }
        
       

    }
   
    public void gameon()
    {
        beginTimer.SetActive(false);
        InGameTime.SetActive(true);

    }
    public void levelup()
    {
        if(scr==2)
        {
            SceneManager.LoadScene("Level 2");
        }
    }
    public void GameOver()
    {
        Debug.Log("GameOver");
        Time.timeScale = 0;
        //GameOverCanvas.SetActive(true);
        SceneManager.LoadScene("gameover");
     }
}
