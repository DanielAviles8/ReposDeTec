using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CarController : MonoBehaviour
{
    System.Random randomCarSelected = new System.Random();
    List<CarAtributes> carlist = new List<CarAtributes>();
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
        carlist.Add(carOne);
        carlist.Add(carTwo);
        carlist.Add(carThree);
        carlist.Add(carFour);
        carlist.Add(carFive);
        carlist.Add(carFive);
        carlist.Add(carSeven);
        carlist.Add(carEight);
        carlist.Add(carNine);
        carlist.Add(carTen);
    }
    public void SelectCars()
    {
        int randomCar1 = randomCarSelected.Next(1, carlist.Count);
        int randomCar2 = randomCarSelected.Next(1, carlist.Count);
        Debug.Log(randomCar1);
        Debug.Log(randomCar2);
        CompareCars(randomCar1, randomCar2);
    }
    public void CompareCars(int index1, int index2)
    {

        int goalDistance = 200;
        float distanceCar1;
        float distanceCar2;
        float timeCar1;
        float timeCar2;
        float lossTimeCar;

        CarAtributes tempo1 = carlist[index1];
        CarAtributes tempo2 = carlist[index2];

        Debug.Log("Autos en carrera");
        Debug.Log(carlist[index1].AtributesToString(tempo1));
        Debug.Log(carlist[index2].AtributesToString(tempo2));

        distanceCar1 = carlist[index1].MaxVelocity / 3.6f;
        distanceCar2 = carlist[index2].MaxVelocity / 3.6f;

        timeCar1 = distanceCar1 / goalDistance;
        timeCar2 = distanceCar2 / goalDistance;

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

        Debug.Log(carlist.Count);
    }
}