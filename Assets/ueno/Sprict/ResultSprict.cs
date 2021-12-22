using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultSprict : MonoBehaviour
{
    [SerializeField] Text _distanseText = default;
    [SerializeField] Text _enemyText = default;
    DistanceScoreManager distanceScoreManager = default;
    public int _distance = 0;
    public int _enemy = 0;


    // Start is called before the first frame update
    void Start()
    {
        distanceScoreManager = GetComponent<DistanceScoreManager>();

        _distanseText.text = "走った距離" + _distance.ToString("D8") + "M";
        _enemyText.text = "倒したブラックサンタ" + _enemy.ToString("D4") + "体";
    }
}
