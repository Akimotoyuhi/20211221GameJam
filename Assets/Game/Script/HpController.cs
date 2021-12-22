using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HpController : MonoBehaviour
{
    /// <summary> Playerの体力 </summary>
    float _maxHp = 5f;
    /// <summary>テキスト</summary>
    [SerializeField] Text _hpText = default;

    Slider hpSlider;
    Player _player;

    int _hp = 0;
    void Start()
    {
        hpSlider = GetComponent<Slider>();
        
        _player = GameObject.FindObjectOfType<Player>();
        _maxHp = _player.m_life;
        //スライダーの最大値の設定
        hpSlider.maxValue = _maxHp;
    }
    
    void Update()
    {
        _hp = _player.m_life;
        _hpText.text = _hp.ToString();
    }

    /// <summary>Hpをスライダーに表示させるメソッド</summary>
    public void UpdateSlider(int hp)
    {
        hpSlider.value = hp;
    }


}