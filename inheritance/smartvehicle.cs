using System;

public class Vehicle
{
    public virtual void Drive()
    {
        Console.WriteLine("Driving the vehicle...");
    }
}

public class ElectricCar : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Driving the electric car silently...");
    }
}

public class GasCar : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Driving the gas-powered car...");
    }
}

public class SelfDrivingCar : ElectricCar
{
    public override void Drive()
    {
        Console.WriteLine("Self-driving electric car on the road...");
    }
}

public class HybridCar : ElectricCar
{
    public override void Drive()
    {
        Console.WriteLine("Driving the hybrid car in electric mode...");
    }
}

public class Program
{
    public static void Main()
    {
        Vehicle electricCar = new ElectricCar();
        electricCar.Drive();

        Vehicle gasCar = new GasCar();
        gasCar.Drive();

        Vehicle selfDrivingCar = new SelfDrivingCar();
        selfDrivingCar.Drive();

        Vehicle hybridCar = new HybridCar();
        hybridCar.Drive();
    }
}
