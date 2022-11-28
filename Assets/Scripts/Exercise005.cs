using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise005 : MonoBehaviour
{
    public int numX;
    void Start()
    {
        Tabla(numX);
    }
    private void Tabla (int num)
    {
        Debug.Log(message: $"{num} X  {1} = {num * 1}");
        Debug.Log(message: $"{num} X  {2} = {num * 2}");
        Debug.Log(message: $"{num} X  {3} = {num * 3}");
        Debug.Log(message: $"{num} X  {4} = {num * 4}");
        Debug.Log(message: $"{num} X  {5} = {num * 5}");
        Debug.Log(message: $"{num} X  {6} = {num * 6}");
        Debug.Log(message: $"{num} X  {7} = {num * 7}");
        Debug.Log(message: $"{num} X  {8} = {num * 8}");
        Debug.Log(message: $"{num} X  {9} = {num * 9}");
        Debug.Log(message: $"{num} X {10} = {num * 10}");
    }

}
