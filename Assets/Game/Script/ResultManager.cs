using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    [SerializeField] Text _distanseText;
    [SerializeField] Text _enemyText;
    //public int _distance = 0;
    //public int _enemy = 0;

    int _enemy = 10;
    int _distance = 10;


    void Start()
    {
        _enemy = GameManager.Instance.Score;


        //int _enemy = gameManager.Score;
        //int _distance = gameManager.m_mileage;

        _distanseText.text = "走った距離" + _distance.ToString("D8") + "M";
        _enemyText.text = "ブラックサンタ" + _enemy.ToString("D4") + "体";

    }
}
