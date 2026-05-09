using DesignPatterns.Structural.Decorator.Interface;

namespace DesignPatterns.Structural.Decorator.Component
{
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple Coffee";
        }

        public double GetCost()
        {
            return 5.0;
        }
    }
}
