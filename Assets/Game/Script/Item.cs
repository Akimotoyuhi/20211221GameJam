using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    [SerializeField] string PlayerTag; //IF文のタグ条件
    [SerializeField] ItemID ID;        //アイテムの識別

    //private bool mutekijyoutai;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == PlayerTag) //プレーヤーにぶつかったら
        {
            GetComponent<Player>().GetItem((int)ID);//プレイヤースクリプトから取得
            Destroy(gameObject);        //消える

        }
       
    }  
}
public enum ItemID
{
    SpeedUp, //スター 
    Score,   //スコアアイテム
}