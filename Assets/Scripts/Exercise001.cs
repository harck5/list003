using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise001 : MonoBehaviour
{
        public string letterX;
    void Start()
    {
            letterC(letterX);
    }
    private bool letterC (string letter)
    {
        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {
            Debug.Log(message: $"{letter} is vowel");
            return true;
        }
        else
        {
            Debug.Log(message: $"{letter} no es vocal");
            return false;
        }
    }
}