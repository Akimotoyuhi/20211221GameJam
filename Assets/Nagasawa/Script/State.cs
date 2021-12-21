using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    [SerializeField] int _aTK;
    public int ATK
    {
        get
        {
            return _aTK;
        }
    }

    [SerializeField] int _sPD;
    public int SPD
    {
        get
        {
            return _sPD;
        }
    }

    [SerializeField] int _hP;
    public int HP
    {
        get
        {
            return _hP;
        }
    }

    [SerializeField] string _flavorText;
    public string FlavorText
    {
        get
        {
            return _flavorText;
        }
    }
}
