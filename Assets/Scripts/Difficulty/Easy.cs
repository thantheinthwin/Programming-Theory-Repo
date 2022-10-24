using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easy : DifficultyButtonX
{
    private int m_diffIndex = 1;

    public int diffIndex
    {
        get { return m_diffIndex; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative point value");
            }
            else
            {
                m_diffIndex = value;
            }
        }
    }

    // Polymorphism
    public override int diffLevel()
    {
        difficulty = m_diffIndex;
        return base.diffLevel();
    }
}
