using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceScoreManager : MonoBehaviour
{
    [SerializeField] Text _distanseText;
    [SerializeField] Text _enemyText;
    public int _distance = 0;
    public int _enemy = 0;
    GameManager gameManager = default;
    bool live;


    void Start()
    {
        gameManager = GetComponent<GameManager>();
        live = true;

        
    }

    void Update()
    {
        int _enemy = gameManager.Score;
        //int _distance = gameManager.m_mileage;

        _distanseText.text = "走った距離" + _distance.ToString("D8") + "M";
        _enemyText.text = "ブラックサンタ" + _enemy.ToString("D4") + "体";

        if (!live)
        {
            Debug.Log("シーン切替");
            //gameManager.ChangeResultScene();
        }
    }
}
