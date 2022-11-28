using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise010 : MonoBehaviour
{
    public int clickCounter;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddOneToCounter();
        }
    }
    private void AddOneToCounter()
    {
        clickCounter++;
        transform.localScale += Vector3.one;
    }
}
