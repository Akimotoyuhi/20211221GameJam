using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpornManager : MonoBehaviour
{
    /// <summary>アイテム生成</summary>
    [SerializeField] GameObject[] itemPrefabs;
    [SerializeField] float spawnDelay = 2;
    /// <summary>アイテム生成のインターバル</summary>
    [SerializeField] float spawnInterval = 1.5f;
    /// <summary>アイテム生成のMaxY軸</summary>
    [SerializeField] float maxY;
    /// <summary>アイテム生成のMinY軸</summary>
    [SerializeField] float minY;

    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
    }

    // Spawn obstacles
    void SpawnObjects()
    {
        Vector3 spawnLocation = new Vector2(14f, Random.Range(maxY, minY));
        int index = Random.Range(0, itemPrefabs.Length);
        Instantiate(itemPrefabs[index], spawnLocation, itemPrefabs[index].transform.rotation);
    }
}
