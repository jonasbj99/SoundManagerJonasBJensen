using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{
    public static MainGameManager instance;

    private int currentScore;

    void Awake()
    {
        instance = this;
    }

    public void AdjustScore(int num)
    {
        currentScore = currentScore + num;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), "Score = " + currentScore);
    }
}
