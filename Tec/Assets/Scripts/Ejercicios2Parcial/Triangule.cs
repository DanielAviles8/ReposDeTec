using UnityEngine;

public class Triangle : MonoBehaviour
{
    private float side1, side2, side3;
    private float ab, ac, bc;
    public float x1, x2, x3;
    public float y1, y2, y3;
    private float height, theBase, perimeter, area;
    private string triangleType;
    private bool equilateral, isosceles, scalene;

    void Start()
    {
        GetTriangle();
        GetHeight();
        GetPerimeter();
        GetArea();
    }

    public void Side1()
    {
        ab = Mathf.Sqrt(((y2 - y1) * (y2 - y1)) + ((x2 - x1) * (x2 - x1)));
        side1 = ab;
    }

    public void Side2()
    {
        ac = Mathf.Sqrt(((y3 - y1) * (y3 - y1)) + ((x3 - x1) * (x3 - x1)));
        side2 = ac;
    }

    public void Side3()
    {
        bc = Mathf.Sqrt(((y3 - y2) * (y3 - y2)) + ((x3 - x2) * (x3 - x2)));
        side3 = bc;
    }

    public void EquilateralTriangle()
    {
        equilateral = (side1 == side2 && side2 == side3);
        Debug.Log("Yo soy un triangulo equilatero, mirame soy perfecto ;D");
    }

    public void IsoscelesTriangle()
    {
        isosceles = (side1 != side2 && side2 == side3);
        Debug.Log("Yo soy un triangulo isosceles :D");
    }

    public void ScaleneTriangle()
    {
        scalene = (side1 != side2 && side2 != side3 && side1 != side3);
        Debug.Log("Yo soy un triamgulo escalemno, admmira pojque soi umnico °U°");
    }

    public void GetTriangle()
    {
        switch (triangleType)
        {

        }
    }

    public void GetHeight()
    {
        height = y1;
        Debug.Log("El lado 2 y 4 de tu triangulo mide" + height);
    }

    public void GetPerimeter()
    {
        perimeter = (theBase * 2) + (height * 2);
        Debug.Log("El perimetro de tu triangulo es" + perimeter);
    }

    public void GetArea()
    {
        area = theBase * height;
        Debug.Log("El area de tu triangulo es" + area);
    }
}