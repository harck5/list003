using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise009 : MonoBehaviour
{
    public int BaseX;
    public int HeightY;
    void Start()
    {
        Triangle(BaseX, HeightY);
    }
    private void Triangle(int Base, int Height)
    {
        if (Base > -1 && Height > -1)
        {
            if (Base * Height / 2 > 0)
            {
                Debug.Log(message: $"The area of ​​the triangle with {Base} base and {Height} height is {Base * Height / 2}");
            }
        }
        else
        {
            Debug.Log(message: $"Variable is less than 0, it is not possible to calculate");
        }
    }
}
