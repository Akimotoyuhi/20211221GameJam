using UnityEngine;
using UnityEngine.UI;

public class DistanceScoreManager : MonoBehaviour
{
    [SerializeField] Text _distanseText;
    [SerializeField] Text _enemyText;
    [SerializeField] Text _prezentText;
    public int _distance = 0;
    public int _enemy = 0;
    int _score;
    //GameManager gameManager = default;
    bool live;


    void Start()
    {
        //gameManager = GetComponent<GameManager>();
        live = true;
    }

    void Update()
    {
        _distance = (int)GameManager.Instance.Mileage;
        _enemy = GameManager.Instance.EnemyCount;
        _score = (int)GameManager.Instance.AllScore;
        _distanseText.text = "走った距離" + _distance.ToString("D8") + "M";
        _enemyText.text = "ブラックサンタ" + _enemy.ToString("D4") + "体";
        _prezentText.text = "Score" + _score.ToString("D8");

        if (!live)
        {
            Debug.Log("シーン切替");
            //gameManager.ChangeResultScene();
        }
    }
}
