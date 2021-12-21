using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    /// <summary>スタート位置</summary>
    private Vector2 startPos;
    /// <summary>背景幅</summary>
    private float repeatWidth;
    /// <summary>背景のスピード</summary>
    [SerializeField] float speed = 10;
    private float leftBound = -15f;

    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x*2;
    }

    /// <summary>背景の繰り返し</summary>
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime, Space.World);
    }
}
