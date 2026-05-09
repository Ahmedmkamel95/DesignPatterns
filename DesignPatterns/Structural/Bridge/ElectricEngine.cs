using System;

namespace DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// 2️⃣ Concrete Implementations
    /// Implement the Implementor interface and define concrete implementations.
    /// </summary>
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric Engine Started");
        }
    }
}
