using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    [SerializeField] Scenemanager _sceneManager;
    [SerializeField] Image _image;
    [SerializeField] 
    void Start()
    {
        _image.color = Color.black;
        _sceneManager.StartFadeIn();
    }
}
