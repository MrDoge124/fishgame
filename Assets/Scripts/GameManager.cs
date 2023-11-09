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
        print(Score);
    }

    public void AddScore()
    {
        Score += 1;
        print(Score);
    }

    public void ChangeLives(int livesamount)
    {
        Lives += livesamount;
        print(Lives);
    }
}
