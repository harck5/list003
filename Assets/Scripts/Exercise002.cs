using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise002 : MonoBehaviour
{
    public int num;
    void Start()
    {
        numC(num);
    }
    private bool numC(int x)
    {
        if (x % 2 == 0)
        {
            Debug.Log(message: $"{x} entered is even");
            return true;
        }
        else
        {
            Debug.Log(message: $"{x} entered is NOT even");
            return false;
        }
    }
}
