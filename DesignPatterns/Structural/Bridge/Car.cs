using System;

namespace DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// 4️⃣ Refined Abstraction
    /// Extends the interface defined by Abstraction.
    /// </summary>
    public class Car : Vehicle
    {
        public Car(IEngine engine) : base(engine)
        {
        }

        public override void Drive()
        {
            engine.Start();
            Console.WriteLine("Car is Driving");
        }
    }
}
