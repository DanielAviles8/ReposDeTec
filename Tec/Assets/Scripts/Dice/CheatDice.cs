using UnityEngine;
public class CheatDice: Dice{

    public int rollResult = 1;

    public void Greetings()
    {
        Debug.Log("Hola, soy un dado cargado");
    }

    public void reRoll(){

        while(rollResult%2 != 0){
            rollResult = Random.Range(1,7);    
        }
        Debug.Log("Este es la tirada de este dado perfecto ;) ;)  " + rollResult);

    }


}