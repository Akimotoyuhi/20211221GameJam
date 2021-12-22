using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardItem : MonoBehaviour
{
    public float speed = 10;
    public float Speed//アイテムの動く速さ
    {
        get
        {
            return speed;　//カプセル化
        }
    }
    
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
