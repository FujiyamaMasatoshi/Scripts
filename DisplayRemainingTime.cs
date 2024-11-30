using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayRemainingTime : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void Init()
    {
        _text.text = GameManager.instance.RemainingTimeString();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = GameManager.instance.RemainingTimeString();
    }
}
