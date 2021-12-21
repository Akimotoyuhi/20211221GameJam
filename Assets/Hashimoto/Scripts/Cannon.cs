using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject muzzlePoint;
    public GameObject ball;
    public float speed = 30f;
    private int attacTime = 0;
    public int intvalTime = 30;
    [SerializeField]
    int Power = 1;


    // Update is called once per frame
    void Update()
    {
        attacTime += 1;
        if (attacTime % intvalTime == 0)
        {
            Fire();

        }
    }
    public void Fire()
    {
        Vector2 mballPos = muzzlePoint.transform.position;
        GameObject newSnowBall = Instantiate(ball, mballPos, transform.rotation);
        Vector2 dir = newSnowBall.transform.up;
        newSnowBall.GetComponent<Rigidbody2D>().velocity = dir * speed;
        SnowBall Yuki = newSnowBall.GetComponent<SnowBall>();
        Yuki.Type = TargetType.Player;
        Yuki.Damage = Power;
        newSnowBall.name = ball.name;
        Destroy(newSnowBall, 0.8f);
    }
}
