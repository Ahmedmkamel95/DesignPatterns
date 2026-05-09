using System;

namespace DesignPatterns.Structural.Facade
{
    public class Lights
    {
        public void TurnOff()
        {
            Console.WriteLine("Lights are OFF");
        }

        public void TurnOn()
        {
            Console.WriteLine("Lights are ON");
        }
    }
}
