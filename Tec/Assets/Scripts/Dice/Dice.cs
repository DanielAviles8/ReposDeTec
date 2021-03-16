using UnityEngine;

public class Dice{

    // Atributes
    public int numberOfFaces;
    public int numberOfEdges;
    private string color;
    private string material;
    public float sizeX;
    public bool available = false;
    private float radius;
    static public int countDice = 10;

    // Constructors
    public Dice(int anumberOfFaces, int anumberOfEdges, string acolor, string amaterial)
    {
        numberOfFaces = anumberOfFaces;
        numberOfEdges = anumberOfEdges;
        color = acolor;
        material = amaterial;
        countDice++;
    }

    public Dice()
    {

    }

    public Dice(int anumberOfFaces)
    {
        numberOfFaces = anumberOfFaces;
    }

    // Methods
    public void helloDice(){
        Debug.Log("Hola desde la clase dice");
    }


    // Getters Setters Properties
    public string Color
    {
        get { return color; }
        set 
        { 
            if(value == "green" | value == "red")
            {
                color = value;    
            }
            else
            {
                color = "NA";
            }             
        }
    }


}

