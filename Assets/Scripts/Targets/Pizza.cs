using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inheritance
public class Pizza : TargetX
{
    private int m_pointValue = 15;

    public int pointValuePizza
    {
        get { return m_pointValue; }
        set
        {
            if(value < 0.0f)
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
