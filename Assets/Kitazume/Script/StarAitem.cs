using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAitem : MonoBehaviour
{

    [SerializeField] string PlayerTag;
    [SerializeField] ItemID ID;

    //private bool mutekijyoutai;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == PlayerTag)//プレーヤーにぶつかったら
        {
            GetComponent<Player>().GetItem((int)ID);
            Destroy(gameObject);   //消える

        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
public enum ItemID
{
    SpeedUp, 
    Score,
}