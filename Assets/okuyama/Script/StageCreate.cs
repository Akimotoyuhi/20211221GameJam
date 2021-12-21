using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCreate : MonoBehaviour
{
    /// <summary>ステージサイズ</summary>
    [SerializeField]int StageSize;
    int StageIndex;
    ///// <summary>プレイヤー</summary>
    //[SerializeField] Transform Target;
    /// <summary>ステージのプレハブ</summary>
    [SerializeField] GameObject[] stagenum;
    /// <summary>スタート時にどのインデックスからステージを生成するのか</summary>
    [SerializeField] int FirstStageIndex;
    /// <summary>事前に生成しておくステージ</summary>
    [SerializeField] int aheadStage;
    /// <summary>生成したステージのリスト</summary>
    [SerializeField] List<GameObject> StageList = new List<GameObject>();

    void Start()
    {
        StageIndex = FirstStageIndex - 1;
        StageManager(aheadStage);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * 10 * Time.deltaTime, Space.World);
    }
    void StageManager(int maps)
    {
        if (maps <= StageIndex)
        {
            return;
        }

        for (int i = StageIndex + 1; i <= maps; i++)//指定したステージまで作成する
        {
            GameObject stage = MakeStage(i);
            StageList.Add(stage);
        }

        while (StageList.Count > aheadStage + 1)//古いステージを削除する
        {
            DestroyStage();
        }

        StageIndex = maps;
    }

    GameObject MakeStage(int index)//ステージを生成する
    {
        int nextStage = Random.Range(0, stagenum.Length);

        GameObject stageObject = (GameObject)Instantiate(stagenum[nextStage], new Vector2(index * StageSize, 0), Quaternion.identity);

        return stageObject;
    }

    void DestroyStage()
    {
        GameObject oldStage = StageList[0];
        StageList.RemoveAt(0);
        Destroy(oldStage);
    }
}
