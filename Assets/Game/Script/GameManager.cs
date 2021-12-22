using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゲームマネージャー<br/>
/// ゲームの進行を管理するクラス
/// </summary>
public class GameManager : MonoBehaviour
{
    [SerializeField, Header("デバッグモード オンにすると邪魔されない")] bool m_debugMode = false;
    [Space]
    [SerializeField] PlayerData m_playerData = null;
    /// <summary>プレイヤーのプレハブ</summary>
    [SerializeField] GameObject[] m_playerPrefab = null;
    /// <summary>プレイヤーの生成位置</summary>
    [SerializeField] Transform m_playerSpawnPos = null;
    /// <summary>生成するプレイヤーのデータID</summary>
    [SerializeField] int m_playerId = 0;
    /// <summary>ゲームのデフォルトの進行速度</summary>
    [SerializeField] float m_defGameSpeed = 1f;
    /// <summary>無敵アイテムの効果時間</summary>
    [SerializeField] float m_mutekiTimeLimit = 2f;
    /// <summary>ゲームの進行速度</summary>
    private float m_gameSpeed = 0f;
    /// <summary>無敵アイテムの時間のタイマー</summary>
    private float m_starTimer = 0f;
    /// <summary>走行距離</summary>
    public float m_mileage = 0;
    public int _enemyCount;
    public float _allScore;
    /// <summary>速度上昇アイテムの効果時間中</summary>
    private bool m_isSpeedUp = false;
    /// <summary>ゲーム中フラグ</summary>
    private bool m_isGame = false;
    /// <summary>ゲーム進行速度</summary>
    public float Speed => m_gameSpeed;
    /// <summary>プレイヤーIDの設定</summary>
    public int PlayerId { set => m_playerId = value; }
    /// <summary>現在スコア</summary>
    public int Score { get; private set; }
    /// <summary>GameManagerのインスタンス</summary>
    public static GameManager Instance { get; private set; }

    [SerializeField]bool _isStartGame;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        if (!m_debugMode)
        {
            GameStart();
        }
        m_isGame = true;
        if(_isStartGame)
        {
            _allScore = 0;
        }
    }

    /// <summary>
    /// ゲーム開始
    /// </summary>
    private void GameStart()
    {
        Setup();
        if (m_playerPrefab[m_playerId])
        {
            GameObject obj = Instantiate(m_playerPrefab[m_playerId], m_playerSpawnPos.position, Quaternion.identity);
            obj.GetComponent<Player>().Setup(m_playerData.m_playerDataBases[m_playerId]);
        }
        else
        {
            Debug.LogWarning("Player is Null");
        }
        m_defGameSpeed = m_playerData.m_playerDataBases[m_playerId].Speed;
        m_gameSpeed = m_defGameSpeed;
    }

    private void Update()
    {
        if (!m_isGame) return;
        if (m_isSpeedUp)
        {
            m_starTimer += Time.deltaTime;
            if (m_starTimer > m_mutekiTimeLimit)
            {
                m_starTimer = 0;
                m_isSpeedUp = false;
                m_gameSpeed = m_defGameSpeed;
            }
        }

        m_mileage += Time.deltaTime * Speed;

        ScoreCount();
    }

    void ScoreCount()
    {
        _allScore = m_mileage + _enemyCount * 10 + Score;
    }

    /// <summary>
    /// 初期化処理
    /// </summary>
    private void Setup()
    {
        Score = 0;
    }

    /// <summary>
    /// ゲーム終了
    /// </summary>
    private void GameFinish()
    {
        //リザルトシーンに移行
    }

    public void GetScore(int score)
    {
        Score += score;
        print("a");
    }

    public void GetSpeedupItem()
    {
        //if (m_isSpeedUp) return;
        m_gameSpeed *= 10;
        m_isSpeedUp = true;
        m_starTimer = 0;
    }
}

public enum PlayerID
{
    Santa,
    Girl,
    Tonakai,
    SnowMan,
    Tree,
    Harada
}
