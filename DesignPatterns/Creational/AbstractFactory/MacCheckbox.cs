using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MacCheckbox : ICheckbox
    {
        public void Check()
        {
            Console.WriteLine("Mac Checkbox");
        }
    }
}
