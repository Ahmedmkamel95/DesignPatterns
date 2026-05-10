using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Check()
        {
            Console.WriteLine("Windows Checkbox");
        }
    }
}
