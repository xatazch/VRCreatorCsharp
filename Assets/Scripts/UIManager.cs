using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public TextMeshProUGUI balloonPopedUI;

    void Start()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        GameManager.BalloonPopped += UpdateUI;
        UpdateUI();
    }

    private void UpdateUI()
    {
        balloonPopedUI.text = 
            GameManager.Instance.poppedBalloons 
            + "/" 
            + GameManager.Instance.balloonsInScene;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
