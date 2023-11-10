using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    MainMenu mainmenu;

    Animator anim;

    public float transitionTime = 1f;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    public void LoadGame()
    {

        anim.SetTrigger("Start");

        //yield return new WaitForSeconds(transitionTime);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("MainGame");
    }
}
