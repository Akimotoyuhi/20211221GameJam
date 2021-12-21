using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class Scenemanager : MonoBehaviour
{
    
    [SerializeField]Image fadeImage;
    public void StartFadeOut()
    {
        this.fadeImage.DOFade(duration: 1f, endValue: 1f);
        //ImageのColorは透明に設定
    }
    public void Start()
    {
        
    }
    public void StartFadeIn()
    {
        this.fadeImage.DOFade(endValue: 0f, duration: 1f);
        //ImageのColorは真っ黒に設定
    }
    public void Fade(bool type)
    {
        if (type)
        {
            this.fadeImage.DOFade(endValue: 0f, duration: 1f);
            //ImageのColorは真っ黒に設定
        }
        else
        {
            this.fadeImage.DOFade(duration: 1f, endValue: 1f);
            //ImageのColorは透明に設定
        }
    }
}
