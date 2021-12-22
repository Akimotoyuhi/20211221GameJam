using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip Audio;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
