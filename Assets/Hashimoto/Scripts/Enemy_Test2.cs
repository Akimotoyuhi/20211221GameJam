using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy_Capsule gameObject = this.GetComponent<Enemy_Capsule>();
        float EnemyHp = gameObject.HP;
    }
}
