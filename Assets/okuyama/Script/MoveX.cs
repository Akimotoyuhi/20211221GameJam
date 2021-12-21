using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : MonoBehaviour
{
    /// <summary>アイテムと背景のスピード</summary>
    float speed;
    /// <summary>アイテムと背景消える位置</summary>
    [SerializeField]　float leftBound = -15f;
    void Start()
    {
        speed = GameManager.Instance.Speed;
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);

        if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }
    }
}
