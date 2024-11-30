using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private int _point = 10;
    [SerializeField] private GameObject _effectPrefab;


    private void OnDestroy()
    {
        GameManager.instance.Score += _point;

        // effectを1秒表示して、消す
        Destroy(Instantiate(_effectPrefab, transform.position, Quaternion.identity), 1.0f);

    }
}
