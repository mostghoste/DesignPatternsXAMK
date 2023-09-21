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

public abstract class CarFactory
{
    public abstract ICar CreateCar();
}

public class SedanFactory : CarFactory
{
    public override ICar CreateCar() { return new Sedan(); }
}

public class SUVFactory : CarFactory
{
    public override ICar CreateCar() { return new SUV(); }
}

public class CarDealer
{
    public void TestDrive(CarFactory factory)
    {
        ICar car = factory.CreateCar();
        car.Drive();
    }
}

class Exercise
{
    static void Main(string[] args)
    {
        CarDealer dealer = new CarDealer();
        dealer.TestDrive(new SedanFactory());
        dealer.TestDrive(new SUVFactory());
    }
}