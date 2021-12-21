using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    int _PlayerHP = 10;

    [SerializeField]
    string _EnemyTag;

    //public float PlayerHp
    //{
    //    get
    //    {
    //        return _PlayerHP;
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == _EnemyTag)
        {
            _PlayerHP--;

            if (_PlayerHP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
