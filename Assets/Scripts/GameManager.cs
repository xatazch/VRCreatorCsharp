using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int baloonsInScene;
    public int poppedBalloons = 0;

    private void Start()
    {
        if(Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        baloonsInScene = GameObject.FindGameObjectsWithTag("Balloon").Length;
    }

    public void BalloonPopped()
    {
        poppedBalloons++;

        if(poppedBalloons >= baloonsInScene)
        {
            WinGame();
        }
    }

    private void WinGame()
    {
        Debug.Log("You are  a Winner !!!");
    }
}
