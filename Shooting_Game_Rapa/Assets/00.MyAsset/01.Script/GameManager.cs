using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] Text currScoreText, bestScoreText;

    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        else Destroy(this);
    }

    [SerializeField] int currScore, bestScore;

    public int CurrScore
    {
        get => currScore;
        set
        {
            currScore = value;
            RefreshScoreUI();
        }
    }
    public int BestScore
    {
        get => bestScore;
        set
        {
            bestScore = value; 
            RefreshBestScoreUI();
        }
    }

    private void Start()
    {
        CurrScore = 0;
        bestScore = 0;
        BestScore = PlayerPrefs.GetInt("BestScore", 0);
    }

    public void AddScore(int score)
    {
        CurrScore += score;
    }

    public void SetBestScore()
    {
        PlayerPrefs.SetInt("BestScore", CurrScore);
    }

    void RefreshScoreUI()
    {
        currScoreText.text = "현재 스코어 : " + CurrScore;
        Debug.Log("헤헤");
    }

    void RefreshBestScoreUI()
    {
        bestScoreText.text = "베스트 스코어 : " + BestScore;
    }

    void InitScore()
    {
        PlayerPrefs.SetInt("BestScore", 0);
    }
}
