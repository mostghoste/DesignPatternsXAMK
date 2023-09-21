using System;

public interface ICar
{
    void Drive();
}

public class Sedan : ICar
{
    public void Drive() => Console.WriteLine("Driving a sedan.");
}

public class SUV : ICar
{
    public void Drive() => Console.WriteLine("Driving an SUV.");
}

public class CarDealer
{
    public void TestDrive(string carType)
    {
        ICar car;
        if (carType == "Sedan")
        {
            car = new Sedan();
        }
        else if (carType == "SUV")
        {
            car = new SUV();
        }
        else
        {
            throw new ArgumentException("Invalid car type");
        }

        car.Drive();
    }
}

class Program
{
    static void Main(string[] args)
    {
        CarDealer dealer = new CarDealer();
        dealer.TestDrive("Sedan");
    }
}