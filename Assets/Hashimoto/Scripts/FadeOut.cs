using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FadeOut : MonoBehaviour
{
    [SerializeField] Image fadeImage;

    public void StartFadeOut()
    {
        this.fadeImage.DOFade(duration: 1.5f, endValue: 1f);
        //ImageのColorは透明に設定
    }
    // Start is called before the first frame update
    void Start()
    {
        StartFadeOut();
    }
}
