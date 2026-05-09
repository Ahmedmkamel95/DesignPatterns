namespace DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// 3️⃣ الـ Abstraction
    /// Defines the abstraction's interface and maintains a reference to an object of type Implementor.
    /// </summary>
    public abstract class Vehicle
    {
        protected IEngine engine;

        protected Vehicle(IEngine engine)
        {
            this.engine = engine;
        }

        public abstract void Drive();
    }
}
