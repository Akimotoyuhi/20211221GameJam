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
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        m_fireTimer = Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && m_fireTimer > m_fireInterval)
        {
            Fire();
        }
    }

    private void Jump()
    {
        if (m_isJump) return;
        m_rb.velocity = Vector2.up * m_jumpPower;
    }

    private void Fire()
    {
        m_fireTimer = 0;
        GameObject obj = Instantiate(m_snowBall, transform.position, Quaternion.identity);
        obj.GetComponent<Rigidbody2D>().velocity = Vector2.right * 10f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            m_isJump = false;
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

    public void GetItem(int id)
    {
        switch (id)
        {
            case 0:
                GameManager.Instance.GetSpeedupItem();
                break;
            case 1:
                GameManager.Instance.GetScoreItem();
                break;
            default:
                break;
        }
    }
}
