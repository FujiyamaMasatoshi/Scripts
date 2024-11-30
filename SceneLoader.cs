using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum SceneType
{
    Title,
    Game,
    Result,
}

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private SceneType scene;


    // 特定のシーンだけロードする
    public void LoadScene()
    {
        SceneManager.LoadScene(scene.ToString());
    }

    // タイトルからゲームシーンをロード
    public void LoadGameSceneFromTitle()
    {
        // ゲームをリセット
        GameManager.instance.NewGame();

        // シーン遷移
        SceneManager.LoadScene(SceneType.Game.ToString());
    }

    public void LoadGameFromResult()
    {
        // ゲームをリセット
        GameManager.instance.NewGame();

        // シーン遷移
        SceneManager.LoadScene(SceneType.Game.ToString());
    }

}
