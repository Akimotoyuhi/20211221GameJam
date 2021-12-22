using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HpController : MonoBehaviour
{
    /// <summary> Playerの体力 </summary>
    [SerializeField] float _maxHp = 5f;
    /// <summary>テキスト</summary>
    [SerializeField] Text _hpText = default;

    Slider hpSlider;

    public int _hp = 0;
    void Start()
    {
        hpSlider = GetComponent<Slider>();
        //スライダーの最大値の設定
        hpSlider.maxValue = _maxHp;
    }
    
    void Update()
    {
        _hpText.text = _hp.ToString();
    }

    /// <summary>Hpをスライダーに表示させるメソッド</summary>
    public void UpdateSlider(int hp)
    {
        hpSlider.value = hp;
    }


}