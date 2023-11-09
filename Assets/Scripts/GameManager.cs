using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int Score;
    int Lives;
    [SerializeField]TextMeshProUGUI scoreText;
    [SerializeField]TextMeshProUGUI livesText;
    // Start is called before the first frame update
    void Start()
    {
        Lives = 3;
        Score = 0;
    }

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

    public void ChangeLives(int livesamount)
    {
        Lives += livesamount;
        livesText.text = Lives.ToString(); ;
    }
}
