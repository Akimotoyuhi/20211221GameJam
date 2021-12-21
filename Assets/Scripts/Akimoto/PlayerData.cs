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
    [SerializeField] Sprite m_image;
    [SerializeField] int m_life;
    [SerializeField] int m_power;
    [SerializeField] float m_fireInterval;
    public Sprite Image => m_image;
    public int Life => m_life;
    public int Power => m_power;
    public float FireInterval => m_fireInterval;
    public float JumpPower { get; } = 10;
}