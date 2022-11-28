using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise004 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Move();
    }
    private void Move()
    {
        transform.Translate(translation: Vector3.right);
    }
}
