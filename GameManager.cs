using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public int Score;
    public const float LimitTime = 30f; //制限時間
    public float Timer; // 時間
    public int Hp = 3; // 空振り

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Title2Game, Result2Gameの時だけ、NewGame()を実行して、リセットさせる。
    public void NewGame()
    {
        Score = 0;
        Timer = 0f;
        Hp = 3;
    }

    // 残り時間(文字列)
    public string RemainingTimeString()
    {
        float remainigTime = LimitTime - Timer;

        // F2で小数第二位、F0で整数
        return remainigTime.ToString("F1");

    }

    // 残り時間 float
    public float RemainingTime()
    {
        return LimitTime - Timer;
    }

    

}
