using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class PickManager : MonoBehaviour
{
    [SerializeField] EventSystem _eventSystem;
    [SerializeField] Text[] _texts;
    [SerializeField] GameObject _firstObj;
    GameManager _gameManager;

    void Start()
    {
        TextMethod(_firstObj);
    }

    public void TextMethod(GameObject obj)
    {
        _texts[0].text = "ATK:" + obj.GetComponent<State>().ATK.ToString();
        _texts[1].text = "SPD:" + obj.GetComponent<State>().SPD.ToString();
        _texts[2].text = "HP:" + obj.GetComponent<State>().HP.ToString();
        _texts[3].text = obj.GetComponent<State>().FlavorText.ToString();
    }
}
