using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    private AudioSource audioSouse;
    [SerializeField] AudioClip[] BGM;
    [SerializeField] AudioClip[] SE;

    public static SoundManager Instance { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>();
        audioSouse = gameObject.AddComponent<AudioSource>();
    }

    private void Awake()
    {
        Instance = this;
    }
    public void Play(AudioType Type, int ID)
    {
        switch (Type)
        {
            case AudioType.BGM:
                audioSouse.clip = BGM[ID];
                audioSouse.Play();
                break;

            case AudioType.SE:
                audioSouse.PlayOneShot(SE[ID]);
                break;
        }

       
    }
    // Update is called once per frame

}


public enum AudioType
{
    BGM,
    SE,
}