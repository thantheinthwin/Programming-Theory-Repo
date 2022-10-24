using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steak : TargetX
{
    private int m_pointValue = 30;

    public int pointValueSteak
    {
        get { return m_pointValue; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative point value");
            }
            else
            {
                m_pointValue = value;
            }
        }
    }
    private void Awake()
    {
        pointValue = m_pointValue;
    }
}
