using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    [SerializeField] Text scoerText;
    public int moneyScore = 0;
    GameManager gameManager = default;
    bool live;

    void Start()
    {
        scoerText.color = new Color(1, 1, 1, 1);
        gameManager = GetComponent<GameManager>();
        live = true;
    }

    void Update()
    {
        scoerText.text = "MONEY " + moneyScore.ToString();
        if (moneyScore >= 10 && moneyScore < 100) scoerText.color = new Color(0, 1, 0, 1);
        else if (moneyScore >= 100 && moneyScore < 1000) scoerText.color = new Color(0, 0, 1, 1);
        else if (moneyScore >= 1000 && moneyScore < 10000) scoerText.color = new Color(1, 0, 1, 1);
        else if (moneyScore >= 10000 && moneyScore < 100000) scoerText.color = new Color(1, 0.92f, 0.016f, 1);
        else if (moneyScore >= 100000 && moneyScore < 1000000) scoerText.color = new Color(1, 0, 0, 1);

        if (!live)
        {
            Debug.Log("シーン切替");
            //gameManager.ChangeResultScene();
        }
    }
}
