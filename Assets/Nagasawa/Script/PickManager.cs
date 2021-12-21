using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PickManager : MonoBehaviour
{
    [SerializeField] EventSystem _eventSystem;
    [SerializeField] Text[] _texts;
    [SerializeField] GameObject _firstObj;
    GameObject _selectObj;

    void Start()
    {
        _texts[0].text =
    }

    void TextMethod(GameObject obj)
    {
        _texts[0].text = obj.GetComponent<State>().ATK.ToString();
        _texts[1].text = obj.GetComponent<State>().SPD.ToString();
        _texts[2].text = obj.GetComponent<State>().HP.ToString();
        _texts[3].text = obj.GetComponent<State>().FlavorText.ToString();
    }
}
