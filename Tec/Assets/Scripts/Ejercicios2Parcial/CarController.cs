using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CarController : MonoBehaviour
{
    System.Random randomSelection = new System.Random();
    List<CarAtributes> listOfCars = new List<CarAtributes>();
    CarAtributes carOne = new CarAtributes(4, 4, 8, 4395, 275, 6, "BMW x6M");
    CarAtributes carTwo = new CarAtributes(2, 4, 8, 2995, 250, 6, "Audi S5 Cabriolet");
    CarAtributes carThree = new CarAtributes(5, 5, 8, 1332, 199, 6, "2020 Jeep Renegade");
    CarAtributes carFour = new CarAtributes(5, 6, 4, 1798, 187, 9, "Honda Jade 2017");
    CarAtributes carFive = new CarAtributes(2, 2, 6, 3493, 308, 6, "2016 Honda NSX II ");
    CarAtributes carSix = new CarAtributes(2, 2, 8, 3902, 340, 7, "2019 Ferrari F8 Tributo");
    CarAtributes carSeven = new CarAtributes(2, 2, 8, 3990, 340, 6, "Ferrari SF90 Spider");
    CarAtributes carEight = new CarAtributes(2, 2, 6, 3995, 300, 7, "Porsche 718 Spyder");
    CarAtributes carNine = new CarAtributes(2, 2, 12, 6498, 320, 7, "Lamborghini Centenario");
    CarAtributes carTen = new CarAtributes(2, 4, 5, 2480, 250, 7, "Audi TT RS Roadster");
    private void Awake()
    {
        listOfCars.Add(carOne);
        listOfCars.Add(carTwo);
        listOfCars.Add(carThree);
        listOfCars.Add(carFour);
        listOfCars.Add(carFive);
        listOfCars.Add(carFive);
        listOfCars.Add(carSeven);
        listOfCars.Add(carEight);
        listOfCars.Add(carNine);
        listOfCars.Add(carTen);
    }
    public void ChooseCar()
    {
        int randomOne = randomSelection.Next(1, listOfCars.Count);
        int randomTwo = randomSelection.Next(1, listOfCars.Count);
        Debug.Log(randomOne);
        Debug.Log(randomTwo);
        CompiteCars(randomOne, randomTwo);
    }
    public void CompiteCars(int index1, int index2)
    {

        int goalDraw = 200;
        float distanceCar1;
        float distanceCar2;
        float timeCar1;
        float timeCar2;
        float lossTimeCar;

        CarAtributes fisrtPlaza = listOfCars[index1];
        CarAtributes secondPlaza = listOfCars[index2];

        Debug.Log("*empieza a sonar Bandolero de fondo");
        Debug.Log(listOfCars[index1].AtributesToString(fisrtPlaza));
        Debug.Log(listOfCars[index2].AtributesToString(secondPlaza));

        distanceCar1 = listOfCars[index1].MaxVelocity / 3.6f;
        distanceCar2 = listOfCars[index2].MaxVelocity / 3.6f;

        timeCar1 = distanceCar1 / goalDraw;
        timeCar2 = distanceCar2 / goalDraw;

        Debug.Log("Tiempo Carro 1 = " + timeCar1 + " seg " + "TiempoCarro 2 =" + +timeCar2 + " seg");

        if (timeCar1 < timeCar2)
        {
            lossTimeCar = timeCar1 - timeCar2;
            Debug.Log("Perdió el auto 1 por = " + lossTimeCar + " seg");
        }
        if (timeCar1 > timeCar2)
        {
            Debug.Log("Ganó auto 1");
        }
        if (timeCar2 < timeCar1)
        {
            lossTimeCar = timeCar2 - timeCar1;
            Debug.Log("Perdió auto 2 por = " + lossTimeCar + " seg");
        }
        if (timeCar2 > timeCar1)
        {
            Debug.Log("Ganó auto 2");
        }
        if (timeCar1 == timeCar2)
        {
            Debug.Log("Ningun auto ganó, ambos tienen la misma velocidad");
        }

    }
    public void ShowCars()
    {
        Debug.Log("CARRO 1 = " + carOne.AtributesToString(carOne));
        Debug.Log("CARRO 2 = " + carTwo.AtributesToString(carTwo));
        Debug.Log("CARRO 3 = " + carThree.AtributesToString(carThree));
        Debug.Log("CARRO 4 = " + carFour.AtributesToString(carFour));
        Debug.Log("CARRO 5 = " + carFive.AtributesToString(carFive));
        Debug.Log("CARRO 6 = " + carSix.AtributesToString(carSix));
        Debug.Log("CARRO 7 = " + carSeven.AtributesToString(carSeven));
        Debug.Log("CARRO 8 = " + carEight.AtributesToString(carEight));
        Debug.Log("CARRO 9 = " + carNine.AtributesToString(carNine));
        Debug.Log("CARRO 10 = " + carTen.AtributesToString(carTen));

        Debug.Log(listOfCars.Count);
    }
}