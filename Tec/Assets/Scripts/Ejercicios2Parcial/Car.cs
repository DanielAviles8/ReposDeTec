public class Car
{
    private string colorCar;
    private float weightCar;
    private float heightCar;
    private int areaCar;

    public Car()
    {
    }
    public Car(float aWeightCar)
    {
        weightCar = aWeightCar;
    }
    public Car(int aAreaCar)
    {
        areaCar = aAreaCar;
    }
    public Car(string aColorCar, float aWeightCar, float aHeightCar, int aAreaCar)
    {
        colorCar = aColorCar;
        weightCar = aWeightCar;
        heightCar = aHeightCar;
        areaCar = aAreaCar;
    }
}