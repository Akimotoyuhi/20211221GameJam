using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject m_snowBall;
    private float m_fireInterval = 0.2f;
    private float m_fireTimer = 0f;
    public int m_life = 0;
    private int m_power = 0;
    private bool m_isJump = false;
    private Rigidbody2D m_rb = null;
    private float m_jumpPower = 10;
    HpController _hpController;
    float _time;
    float _lastTime;
    [SerializeField] Animator _anim;

    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        _hpController = GameObject.FindObjectOfType<HpController>();
        
        
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
        _hpController.UpdateSlider(m_life);
        _time += Time.deltaTime;
        _anim.SetBool("isGrounded", !m_isJump);
    }

    private void Jump()
    {
        Vector2 velocity = m_rb.velocity;
        if (Input.GetButtonDown("Jump") && !m_isJump)
        {
            velocity.y = m_jumpPower;
        }
        else if (!Input.GetButton("Jump") && velocity.y > -1)
        {
            velocity.y = -m_jumpPower;
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
        _anim.SetTrigger("attackTrigger");
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SnowBall blt = collision.gameObject.GetComponent<SnowBall>();
        if (blt && blt.Type == TargetType.Player)
        {
            Damage(blt.Damage);
        }
    }

    public void Setup(PlayerDataBase data)
    {
        m_life = data.Life;
        m_power = data.Power;
    }

    /// <summary>
    /// 被ダメージ処理
    /// </summary>
    /// <param name="damage"></param>
    public void Damage(int damage)
    {
        m_life -= damage;
        _anim.SetTrigger("damageTrigger");
        if (m_life <= 0)
        {
            _hpController.UpdateSlider(m_life);
            _lastTime = _time;
            GameManager.Instance.m_isGame = false;
            Destroy(gameObject);
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
