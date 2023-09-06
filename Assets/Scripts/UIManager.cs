using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public TextMeshProUGUI balloonPopedUI;
    public CanvasGroup winPanel;
    public float fadeSpeed = 1;

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

    public IEnumerator ShowWinPanel()
    {
        Debug.Log("Inside ShowWinPanel");
        while (winPanel.alpha < 1)
        {
            winPanel.alpha += Time.deltaTime * fadeSpeed;
            Debug.Log("winPanel.alpha: " + winPanel.alpha.ToString());
            yield return new WaitForEndOfFrame();
        }
    }
}
