using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{
    public int Damage
    {
        get;
        set;
    }
    public TargetType Type
    {
        get;
        set;
    }
}
public enum TargetType
{
    Player,
    Enemy
}