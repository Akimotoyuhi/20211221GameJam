using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerData m_playerData = null;
    [SerializeField] GameObject m_playerPrefab = null;
    [SerializeField] int m_playerId = 0;
    [SerializeField] float m_gameSpeed = 0f;
    private bool m_isGame = false;
    public static GameManager Instance { get; private set; }

    void Start()
    {
        Instantiate(m_playerPrefab).GetComponent<Player>().Setup(m_playerData.m_playerDataBases[m_playerId]);
    }

    void Update()
    {

    }
}
