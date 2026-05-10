using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving Car");
        }
    }
}
