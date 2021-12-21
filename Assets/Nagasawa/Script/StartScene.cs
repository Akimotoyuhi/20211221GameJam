using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    [SerializeField] Scenemanager _sceneManager;
    [SerializeField] Image _image;
    void Start()
    {
        _image.color = Color.black;
        _sceneManager.StartFadeIn();
    }
}
