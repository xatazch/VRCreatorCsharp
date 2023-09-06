using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static Action BalloonPopped;

    public int balloonsInScene;
    public int poppedBalloons = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        balloonsInScene = GameObject.FindGameObjectsWithTag("Balloon").Length;

        BalloonPopped += OnBalloonPopped;
    }

    private void OnDestroy()
    {
        BalloonPopped -= OnBalloonPopped;
    }

    public void OnBalloonPopped()
    {
        poppedBalloons++;

        if (poppedBalloons >= balloonsInScene)
        {
            WinGame();
        }
    }

    private void WinGame()
    {
        Debug.Log("You are  a Winner !!!");
        StartCoroutine(UIManager.Instance.ShowWinPanel());
    }
}
