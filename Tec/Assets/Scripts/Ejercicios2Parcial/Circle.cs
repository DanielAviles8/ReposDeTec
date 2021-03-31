using UnityEngine;

public class Circle : MonoBehaviour
{
    private int pi;
    public float x1, x2;
    public float y1, y2;
    private float ab;
    private float radious, diameter, perimeter, area;

    void Start()
    {
        GetRadious();
        GetDiameter();
        GetPerimeter();
        GetArea();
    }

    public void GetRadious()
    {
        ab = Mathf.Sqrt(((y2 - y1) * (y2 - y1)) + ((x2 - x1) * (x2 - x1)));
        radious = ab;
        Debug.Log("El radio de tu circulo mide" + radious);
    }

    public void GetDiameter()
    {
        diameter = radious * 2;
        Debug.Log("El diametro de tu circulo mide" + diameter);
    }

    public void GetPerimeter()
    {
        perimeter = 3.1416f * diameter;
        Debug.Log("El perimetro de tu circulo es" + perimeter);
    }

    public void GetArea()
    {
        area = 3.1416f * (radious * radious);
        Debug.Log("El area de tu circulo es" + area);
    }
    public float Area
    {
        get { return area; }
    }
    public float Radious
    {
        set { radious = value; }
    }
}