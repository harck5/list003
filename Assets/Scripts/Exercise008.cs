using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise008 : MonoBehaviour
{
    public int yearX;
    void Start()
    {
        Year(yearX);
    }
    private bool Year (int x)
    {
        if (x % 4 == 0 && (x % 100 != 0 || x % 400 == 0))
        {
            Debug.Log(message: $"Year {x} is a leap year");
            return true;
        }
        else
        {
            Debug.Log(message: $"Year {x} is NOT a leap year");
            return false;
        }
    }
}
