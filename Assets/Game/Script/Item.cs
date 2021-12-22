using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    [SerializeField] string PlayerTag; //IF文のタグ条件
    [SerializeField] ItemID ID;        //アイテムの識別

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == PlayerTag) //プレーヤーにぶつかったら
    //    {
    //        GetComponent<Player>().GetItem((int)ID);//プレイヤースクリプトから取得
    //        Destroy(gameObject);        //消える
    //    }
    //    print("a");
    //    Debug.Log("a");
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == PlayerTag) //プレーヤーにぶつかったら
        {
            collision.GetComponent<Player>().GetItem((int)ID);//プレイヤースクリプトから取得
            Destroy(gameObject);        //消える
        }
    }

}
public enum ItemID
{
    SpeedUp, //スター 
    Score,   //スコアアイテム
}