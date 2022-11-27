using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise001 : MonoBehaviour
{
        public string letter;
    void Start()
    {
            letterC();
    }
    private bool letterC()
    {
        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {
            Debug.Log(message: $"{letter} is a vowel");
            return true;
        }
        else
        {
            Debug.Log(message: $"{letter} is NOT a vowel");
            return false;
        }
    }
}