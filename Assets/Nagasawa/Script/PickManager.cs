using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PickManager : MonoBehaviour
{
    [SerializeField] EventSystem _eventSystem;
    [SerializeField] Text[] _texts;
    GameObject _selectObj;

    void Start()
    {
        
    }
}
