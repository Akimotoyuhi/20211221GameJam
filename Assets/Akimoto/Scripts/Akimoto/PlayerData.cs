using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public List<PlayerDataBase> m_playerDataBases = new List<PlayerDataBase>();
}

[System.Serializable]
public class PlayerDataBase
{
    public string m_name;
    [SerializeField, Header("画像 いらんかも")] Sprite m_image;

    [SerializeField, Header("体力")] int m_life;
    [SerializeField, Header("攻撃力")] int m_power;
    [SerializeField, Header("攻撃頻度")] float m_fireInterval;
    [SerializeField, Header("速度")] float m_speed;
    public Sprite Image => m_image;
    public int Life => m_life;
    public int Power => m_power;
    public float FireInterval => m_fireInterval;
    public float Speed => m_speed;
    public float JumpPower { get; } = 15;
}