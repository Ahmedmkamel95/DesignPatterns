using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving Bike");
        }
    }
}
