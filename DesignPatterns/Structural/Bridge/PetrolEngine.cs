using System;

namespace DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// 2️⃣ Concrete Implementations
    /// Implement the Implementor interface and define concrete implementations.
    /// </summary>
    public class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Petrol Engine Started");
        }
    }
}
