using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    int _PlayerHP = 10;

    [SerializeField]
    string _SnowBallTag;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SnowBall YukiObj = collision.GetComponent<SnowBall>();
        if (YukiObj && YukiObj.Type == TargetType.Player)
        {

            _PlayerHP -= YukiObj.Damage;
        }
    }
}
