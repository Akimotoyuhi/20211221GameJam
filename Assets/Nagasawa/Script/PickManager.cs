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
    GameObject _selectObj;

    void Start()
    {
        _selectObj = _firstObj;
        TextMethod(_selectObj);
    }

    //void Update()
    //{
    //    Select();
    //    TextMethod(_selectObj);
    //}

    //void Select()
    //{
    //    if (_eventSystem.currentSelectedGameObject)
    //    {
    //        _selectObj = _eventSystem.currentSelectedGameObject.gameObject;
    //    }
    //}

    public void TextMethod(GameObject obj)
    {
        _texts[0].text = obj.GetComponent<State>().ATK.ToString();
        _texts[1].text = obj.GetComponent<State>().SPD.ToString();
        _texts[2].text = obj.GetComponent<State>().HP.ToString();
        _texts[3].text = obj.GetComponent<State>().FlavorText.ToString();
    }
}
