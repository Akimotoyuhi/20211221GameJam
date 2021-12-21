using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Capsule : MonoBehaviour
{
    #region
    [Header("ブラックサンタの体力")]
    [SerializeField] float _hp = 10;
    [Header("雪のタグ")]
    [SerializeField] string _snowTag;
    //[Header("プレイヤーのHP")]
    //[SerializeField] float _HpPlayer = 10;
    [Header("プレイヤーのタグ")]
    [SerializeField] string _PlayerTag;

    
    

    public float HP
    {
        get
        {
            return _hp;
        }
    }
    //public float DamegePlayer
    //{
    //    get
    //    {
    //        return _HpPlayer;
    //    }
    //}
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SnowBall YukiObj = collision.GetComponent<SnowBall>();
        if (YukiObj && YukiObj.Type == TargetType.Enemy)
        {

            _hp -= YukiObj.Damage;
        }
    }
    #endregion
}
