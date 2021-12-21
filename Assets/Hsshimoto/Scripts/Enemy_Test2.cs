using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy_Test gameObject = this.GetComponent<Enemy_Test>();
        float EnemyHp = gameObject.HP;
        float DamegeHp = gameObject.DamegePlayer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
