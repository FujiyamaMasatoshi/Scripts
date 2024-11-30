using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ballがぶつかったらresultへ遷移
        if (collision.collider.CompareTag("DeadLine"))
        {
            GameManager.instance.Hp--;
            if (GameManager.instance.Hp <= 0)
            {
                SceneManager.LoadScene(SceneType.Result.ToString());
            }
        }
    }
}
