using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int m_life = 0;
    [SerializeField]
    private int m_power = 0;
    
    void Start()
    {

    }
    
    void Update()
    {

    }

    public void Setup(PlayerDataBase data)
    {
        GetComponent<SpriteRenderer>().sprite = data.Image;
        m_life = data.Life;
        m_power = data.Power;
    }

    public void GetItem()
    {
        
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("hit");
    //}
}
