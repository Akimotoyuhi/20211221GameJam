using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerData m_playerData = null;
    [SerializeField] GameObject m_playerPrefab = null;
    [SerializeField] int m_playerId = 0;
    [SerializeField] float m_defGameSpeed = 0f;
    [SerializeField] float m_starTimeLimit = 0f;
    private float m_gameSpeed = 0f;
    private float m_starTimer = 0f;
    private int m_score = 0;
    private bool m_isSpeedUp = false;
    private bool m_isGame = false;
    public int Score => m_score;
    public float Speed => m_gameSpeed;
    public int PlayerId { set => m_playerId = value; }
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        GameStart();
    }

    private void GameStart()
    {
        if(m_playerPrefab)
        {
            GameObject obj = Instantiate(m_playerPrefab, Vector2.zero, Quaternion.identity);
            obj.GetComponent<Player>().Setup(m_playerData.m_playerDataBases[m_playerId]);
            
        }
        else
        {
            Debug.LogWarning("Player is Null");
        }
        m_gameSpeed = m_defGameSpeed;
    }

    private void Update()
    {
        if (!m_isGame) return;
        if (m_isSpeedUp)
        {
            m_starTimer += Time.deltaTime;
            if (m_starTimer > m_starTimeLimit)
            {
                m_gameSpeed = m_defGameSpeed;
            }
        }
    }

    public void GetScoreItem()
    {
        m_score += 100;
    }

    public void GetSpeedupItem()
    {
        m_gameSpeed *= 10;
        m_isSpeedUp = true;
    }
}
