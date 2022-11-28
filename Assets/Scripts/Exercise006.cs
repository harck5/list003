using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise006 : MonoBehaviour
{
    public int numX;
    public int numY;
    void Start()
    {
        mayorQue(numX, numY);
    }
    private void mayorQue(int x, int y)
    {
        if(x < y)
        {
            Debug.Log(message: $"{x} is less than {y}");
        }
        if (x > y)
        {
            Debug.Log(message: $"{x} is greater than {y}");
        }
        if (x == y)
        {
            Debug.Log(message: $"{x} is equal than {y}");
        }
    }

}
