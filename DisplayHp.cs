using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayHp : MonoBehaviour
{
    [SerializeField] private GameObject _firstHeart;
    [SerializeField] private GameObject _secondHeart;
    [SerializeField] private GameObject _thirdHeart;

    private void Start()
    {
        Init();

    }

    public void Init()
    {
        SetHeartUI();
    }

    public void SetHeartUI()
    {
        if (GameManager.instance.Hp == 3)
        {
            _firstHeart.SetActive(true);
            _secondHeart.SetActive(true);
            _thirdHeart.SetActive(true);
        }
        else if (GameManager.instance.Hp == 2)
        {
            _firstHeart.SetActive(true);
            _secondHeart.SetActive(true);
            _thirdHeart.SetActive(false);
        }
        else if (GameManager.instance.Hp == 1)
        {
            _firstHeart.SetActive(true);
            _secondHeart.SetActive(false);
            _thirdHeart.SetActive(false);
        }
        else
        {
            _firstHeart.SetActive(false);
            _secondHeart.SetActive(false);
            _thirdHeart.SetActive(false);
        }
    }

    private void Update()
    {
        SetHeartUI();
    }
}
