using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class Scenemanager : MonoBehaviour
{
    [Header("イメージを貼り付ける")]
    [SerializeField]Image _fadeImage;
    public void StartFadeOut()//フェードアウト関数
    {
        this._fadeImage.DOFade(duration: 1f, endValue: 1f);
        //ImageのColorは透明に設定
    }
    public void StartFadeIn()//フェードイン関数
    {
        this._fadeImage.DOFade(endValue: 0f, duration: 1f);
        //ImageのColorは真っ黒に設定
    }
    public void Fade(bool type, string scene)//呼び出す関数
    {
        if (type)
        {
            this._fadeImage.DOFade(endValue: 0f, duration: 1f);
            //ImageのColorは真っ黒に設定
        }
        else
        {
            this._fadeImage.DOFade(duration: 1f, endValue: 1f);
            //ImageのColorは透明に設定
        }
    }
}
