using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Windows Button");
        }
    }
}
