using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle
{
    public int numberOfEdges = 0;
    public int radious = 10;

    public void ShowCircle()
    {
        Debug.Log("tu circulo tiene vertices =" + numberOfEdges);
        Debug.Log("tu circulo tiene un radio de:" + radious);
    }
    
}
