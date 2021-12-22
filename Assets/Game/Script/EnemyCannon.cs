using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCannon : MonoBehaviour
{
    public GameObject muzzlePoint;
    public GameObject ball;
    public float speed = 30f;
    [SerializeField]
    int _power = 1;

    public void Fire()
    {
        Transform mballPos = muzzlePoint.transform;
        GameObject newSnowBall = Instantiate(ball, mballPos.position,Quaternion.identity);
        Vector2 dir = Vector2.right * -1;
        newSnowBall.GetComponent<Rigidbody2D>().velocity = dir * speed;
        SnowBall Yuki = newSnowBall.GetComponent<SnowBall>();
        Yuki.Type = TargetType.Player;
        Yuki.Damage = _power;
        newSnowBall.name = ball.name;
        Destroy(newSnowBall, 0.8f);
    }
}
