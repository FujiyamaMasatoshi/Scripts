using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // update毎に呼ぶ
    public void CheckIsOver()
    {
        // 残り残機
        if (GameManager.instance.Hp <= 0)
        {
            SceneManager.LoadScene(SceneType.Result.ToString());
        }
        // 残り時間
        if (GameManager.instance.RemainingTime() < 0)
        {
            SceneManager.LoadScene(SceneType.Result.ToString());
        }

        // Stageのブロックが全て消えたら、
        // おそらく、LoadScene(Game or CurrentScene())を呼び出している箇所がありそう
        
    }

    private void Update()
    {
        GameManager.instance.Timer += Time.deltaTime; // 時間を進める
        CheckIsOver();
    }

}
