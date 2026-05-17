using System;

namespace DesignPatterns.Structural.Flyweight
{
    /// <summary>
    /// Flyweight object that contains shared intrinsic state for tree types.
    /// </summary>
    public class TreeType
    {
        public string Name { get; }
        public string Color { get; }

        public TreeType(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"{Name} tree ({Color}) at {x},{y}");
        }
    }
}