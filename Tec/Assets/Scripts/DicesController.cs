using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicesController : MonoBehaviour
{
    Dice woodDice = new Dice(4, 4, "green", "wood");
    Dice redDice = new Dice(6, 8, "red", "plastic");
    Dice sixFaceDice = new Dice(6, 8, "blue", "plastic");
    Dice dice1 = new Dice();
    Dice dice6 = new Dice(6);

    CheatDice crookedDice = new CheatDice();
 



    // Start is called before the first frame update
    void Start()
    {
    
    Debug.Log("Color dado madera: " + woodDice.Color);
    woodDice.Color = "red";
    Debug.Log("Color dado madera: " + woodDice.Color);
    Debug.Log("Hay un total de " + Dice.countDice + " dados");

    crookedDice.Greetings();
    crookedDice.helloDice();

    


    }

    // Update is called once per frame
    void Update()
    {
        //CheatDice.reRoll();    
    }
}
