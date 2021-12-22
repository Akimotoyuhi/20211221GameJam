using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    [SerializeField] Text _distanseText;
    [SerializeField] Text _enemyText;
    [SerializeField] Text _totalText;

    //public int _distance = 0;
    //public int _enemy = 0;

    int _enemy = 10;
    int _distance = 10;
    int _totalscore;

    void Start()
    {
        _enemy = GameManager.Instance._enemyCount;

        _distance = (int)GameManager.Instance. m_mileage;

        _totalscore = (int)GameManager.Instance._allScore;

        _distanseText.text = "走った距離" + _distance.ToString("D8") + "M";
        _enemyText.text = "ブラックサンタ" + _enemy.ToString("D4") + "体";

        _totalText.text = "トータルスコア" + _totalscore.ToString("D10");
    }
}
