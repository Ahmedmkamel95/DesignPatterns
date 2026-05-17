using System;

namespace DesignPatterns.Behavioral.Command
{
    /// <summary>
    /// Receiver class that knows how to perform the actual operations.
    /// </summary>
    public class Light
    {
        public string Location { get; }

        public Light(string location)
        {
            Location = location;
        }

        public void TurnOn()
        {
            Console.WriteLine($"{Location} light is ON.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{Location} light is OFF.");
        }
    }
}