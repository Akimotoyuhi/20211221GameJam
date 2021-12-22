using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    [SerializeField] GameObject SoundMG;
    [SerializeField] AudioType type;
    [SerializeField] int ID;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnClick()
    {
        SoundMG.GetComponent<SoundManager>().Play(type,ID);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
