using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise003 : MonoBehaviour
{
    public int numX;
    public int numY;
    public void Start()
    {
        Division(numX, numY);
    }
    private void Division(int x, int y)
    {
        if (x % y == 0)
        {
            Debug.Log(message:$"{x} / {y} = {x / y} is exact");
        }
        else
        {
            Debug.Log(message:$"{x} / {y} = {x / y} is NOT exact");
        }
    }
}
