using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise007 : MonoBehaviour
{
    public int numX;
    void Start()
    {
        Absolut(numX);
    }
    private void Absolut(int x)
    {
        if(x > 0)
        {
            Debug.Log(message: $"{x}");
        }
        if (x < 0)
        {
            Debug.Log(message: $"{-x}");
        }
    }
}
