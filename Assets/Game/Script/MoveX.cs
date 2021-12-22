using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : MonoBehaviour
{
    /// <summary>アイテムと背景のスピード</summary>
    float speed;
    void Start()
    {
        speed = GameManager.Instance.Speed;
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
    }
}
