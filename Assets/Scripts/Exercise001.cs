using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise001 : MonoBehaviour
{
        public string letterX;
    void Start()
    {
<<<<<<< Updated upstream
            letterC(letterX);
    }
    private bool letterC(string letter)
    {
        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {
            Debug.Log(message: $"{letter} is a vowel");
=======
        letterC();

    }
    private bool letterC()
    {
        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {
            Debug.Log(message: $"{letter} is vowel");
>>>>>>> Stashed changes
            return true;
        }
        else
        {
<<<<<<< Updated upstream
            Debug.Log(message: $"{letter} is NOT a vowel");
=======
            Debug.Log(message: $"{letter} no es vocal");
>>>>>>> Stashed changes
            return false;
        }
    }
}