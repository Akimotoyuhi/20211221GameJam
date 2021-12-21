using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Test : MonoBehaviour
{
    [SerializeField]
    float _hp = 10;//ブラックサンタの体力
    [SerializeField] 
    string _snowTag;//雪のタグ
    [SerializeField]
    float _HpPlayer = 10;//プレイヤーのHP
    [SerializeField]
    string _PlayerTag;//プレイヤーのタグ

    public float HP
    {
        get
        {
            return _hp;
        }
    }

    public float DamegePlayer
    {
        get
        {
            return _HpPlayer;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == _snowTag)
        {
            Debug.Log("当たった");
            //Destroy(gameObject);
            Destroy(collision.gameObject);
            _hp--;
        }
        if (_hp <= 0)
        {
            Destroy(gameObject);
            Debug.Log("ブラックサンタが消えた");
        }
        if (collision.gameObject.tag == _PlayerTag)
        {
            Debug.Log("Playerに当たった");
            _HpPlayer--;
            if (_HpPlayer <= 0)
            {
                Destroy(collision.gameObject);
                Debug.Log("Playerが消えた");
            }
        }
    }
}
