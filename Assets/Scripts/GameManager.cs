using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int Score;
    int Lives;
    // Start is called before the first frame update
    void Start()
    {
        Lives = 3;
        Score = 0;
    }

    public void AddScore(int scoretoadd)
    {
        Score += scoretoadd;
    }

    public void AddScore()
    {
        Score += 1;
    }

    public void ChangeLives(int livesamount)
    {
        Lives += livesamount;
    }
}
