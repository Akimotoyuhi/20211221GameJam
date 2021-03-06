using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Capsule : MonoBehaviour
{
    #region
    [Header("ブラックサンタの体力")]
    [SerializeField] float _hp = 10;

    public float EnemyHP
    {
        get
        {
            return _hp;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SnowBall YukiObj = collision.GetComponent<SnowBall>();
        if (YukiObj && YukiObj.Type == TargetType.Enemy)
        {
            _hp -= YukiObj.Damage;
            Destroy(collision.gameObject);
            if (_hp <= 0)
            {
                Destroy(gameObject);
                GameManager.Instance.EnemyCount++;
            }
            
        }
    }
    #endregion
}
