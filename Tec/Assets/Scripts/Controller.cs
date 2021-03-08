using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public int chooseFigure = Random.Range(1, 5);

    void Update()
    {
        if(chooseFigure == 1)
        {
            Circle.ShowCircle();
        }
    } 
}
