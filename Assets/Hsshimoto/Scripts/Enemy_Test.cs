using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Test : MonoBehaviour
{
    [SerializeField]
    float _hp = 10;//体力
    [SerializeField] 
    string _snowTag;
    [SerializeField]
    float _DamegePlayer = 1;
    [SerializeField]
    string _PlayerTag;



    public float HP
    {
        get
        {
            return _hp;
        }
    }

    public float DamegePlayer
    {
        get
        {
            return _DamegePlayer;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == _snowTag)
        {
            Debug.Log("当たった");
            //Destroy(gameObject);
            Destroy(collision.gameObject);
            _hp--;
        }
        if (_hp <= 0)
        {
            Destroy(gameObject);
            Debug.Log("GameOver");
        }
        if (collision.gameObject.tag == _PlayerTag)
        {
            Debug.Log("Playerに当たった");
            _DamegePlayer --;
        }
        
        
    }


}
