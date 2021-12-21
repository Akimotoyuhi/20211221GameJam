using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int m_life = 0;
    private int m_power = 0;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Setup(PlayerDataBase data)
    {
        GetComponent<SpriteRenderer>().sprite = data.Image;
        m_life = data.Life;
        m_power = data.Power;
    }

    public void GetItem(int id)
    {
        switch (id)
        {
            case 0:
                //アイテムID０の処理
                break;
            case 1:
                //アイテムID１の処理
                break;
            default:
                break;
        }
    }
}
