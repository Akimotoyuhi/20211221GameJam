using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrackSantMove : MonoBehaviour
{
    float speed = 10;
    void Start()
    {
        //speed = GameManager.Instance.Speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed/2 * Time.deltaTime, Space.World);
    }
}
