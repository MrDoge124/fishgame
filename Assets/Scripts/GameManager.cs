using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int Score;
    int Lives;
    [SerializeField]TextMeshProUGUI scoreText;
    [SerializeField]TextMeshProUGUI livesText;
    public bool gameOver;
    [SerializeField]GameObject gameoverUI;
    // Start is called before the first frame update
    void Start()
    {
        Lives = 3;
        Score = 0;
        gameOver = false;
        gameoverUI.SetActive(false);
        Time.timeScale = 1f;
    }
    #region GameStates
    public void EndGame() 
    {
        gameoverUI.SetActive(true);
        gameOver = true;
        Time.timeScale = 0;
    }
    public void ChangeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    #endregion
    #region score
    public void AddScore(int scoretoadd)
    {
        Score += scoretoadd;
        scoreText.text = Score.ToString();
    }

    public void AddScore()
    {
        Score += 1;
        scoreText.text = Score.ToString();
    }
    #endregion
    #region lives
    public void AddLives(int livesamount)
    {
        Lives += livesamount;
        livesText.text = Lives.ToString();
    }
    public void SubtractLives(int livesamount)
    {
        if (Lives != 0)
        {
            Lives -= livesamount;
            livesText.text = Lives.ToString();
            if (Lives == 0)
            {
                EndGame(); 
            }
        }
    }
    #endregion
}
