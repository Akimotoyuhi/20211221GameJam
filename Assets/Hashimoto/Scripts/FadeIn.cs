using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] Image fadeImage;
    // Start is called before the first frame update
    void Start()
    {
        StartFadeIn();
    }
    public void StartFadeIn()
    {
        this.fadeImage.DOFade(endValue: 0f, duration: 1f);
        //ImageのColorは真っ黒に設定
    }
    
}
