﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Animator startButton;
    public Animator settingsButton;
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }
    public void OpenSettings()
    {
        startButton.SetBool("ishidden", true);
        settingsButton.SetBool("ishidden", true);
        dialog.SetBool("isHidden", false);
    }
    public Animator dialog;
    public void CloseSettings()
    {
        startButton.SetBool("isHidden", false);
        settingsButton.SetBool("isHidden", false);
        dialog.SetBool("isHidden", true);
    }
}