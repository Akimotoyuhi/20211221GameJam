using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Test : MonoBehaviour
{    
    [Header("ブラックサンタの体力")][SerializeField] float _hp = 10;
    [Header("雪のタグ")][SerializeField]string _snowTag;
    [Header("プレイヤーのHP")][SerializeField]float _HpPlayer = 10;
    [Header("プレイヤーのタグ")] [SerializeField]string _PlayerTag;

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
