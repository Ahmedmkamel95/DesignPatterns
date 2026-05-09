// Adaptee class in the Adapter pattern - the existing class with incompatible interface
// This is the class that needs to be adapted to work with the target interface
namespace DesignPatterns.Structural.Adapter;

using System;

public class TypeCCharger
{
    public void ChargeWithTypeC()
    {
        Console.WriteLine("Charging with Type-C");
    }
}