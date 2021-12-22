using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject m_snowBall;
    private float m_fireInterval = 1f;
    private float m_fireTimer = 0f;
    private int m_life = 0;
    private int m_power = 0;
    private bool m_isJump = false;
    private Rigidbody2D m_rb = null;
    private float m_jumpPower = 0;

    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
        m_fireTimer += Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && m_fireTimer > m_fireInterval)
        {
            m_fireTimer = 0;
            Fire();
        }
    }

    private void Jump()
    {
        Vector2 velocity = m_rb.velocity;
        if (Input.GetButtonDown("Jump") && !m_isJump)
        {
            velocity.y = m_jumpPower;
        }
        else if (!Input.GetButton("Jump") && velocity.y > 0)
        {
            velocity.y = 0;
        }
        m_rb.velocity = velocity;
    }

    private void Fire()
    {
        GameObject obj = Instantiate(m_snowBall, transform.position, Quaternion.identity);
        obj.GetComponent<Rigidbody2D>().velocity = Vector2.right * 10f;
        SnowBall s = obj.GetComponent<SnowBall>();
        s.Damage = m_power;
        s.Type = TargetType.Enemy;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            m_isJump = false;
        }

        SnowBall blt = collision.gameObject.GetComponent<SnowBall>();
        if (blt && blt.Type == TargetType.Player)
        {
            m_life -= blt.Damage;
            if (m_life < 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            m_isJump = true;
        }
    }

    public void Setup(PlayerDataBase data)
    {
        GetComponent<SpriteRenderer>().sprite = data.Image;
        m_life = data.Life;
        m_power = data.Power;
        m_fireInterval = data.FireInterval;
        m_jumpPower = data.JumpPower;
    }

    /// <summary>
    /// 被ダメージ処理
    /// </summary>
    /// <param name="damage"></param>
    public void Damage(int damage)
    {
        m_life -= damage;
        if (m_life < 0)
        {
            Debug.Log("～死～");
        }
    }

    public void GetItem(int id)
    {
        switch (id)
        {
            case 0:
                GameManager.Instance.GetSpeedupItem();
                break;
            case 1:
                GameManager.Instance.GetScore(100);
                break;
            default:
                break;
        }
    }
}
