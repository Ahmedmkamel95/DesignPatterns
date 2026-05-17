using System;

namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Product class representing a computer built by the Builder pattern.
    /// </summary>
    public class Computer
    {
        public string Cpu { get; init; }
        public int Ram { get; init; }
        public string Storage { get; init; }
        public string GraphicsCard { get; init; }
        public string OperatingSystem { get; init; }

        public Computer(string cpu, int ram, string storage, string graphicsCard, string operatingSystem)
        {
            Cpu = cpu;
            Ram = ram;
            Storage = storage;
            GraphicsCard = graphicsCard;
            OperatingSystem = operatingSystem;
        }

        public void PrintSpecifications()
        {
            Console.WriteLine("Computer Specifications:");
            Console.WriteLine($"CPU: {Cpu}");
            Console.WriteLine($"RAM: {Ram}GB");
            Console.WriteLine($"Storage: {Storage}");
            Console.WriteLine($"Graphics Card: {GraphicsCard}");
            Console.WriteLine($"Operating System: {OperatingSystem}");
        }
    }
}