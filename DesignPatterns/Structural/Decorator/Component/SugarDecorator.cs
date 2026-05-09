using DesignPatterns.Structural.Decorator.Interface;

namespace DesignPatterns.Structural.Decorator.Component
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return coffee.GetDescription() + ", Sugar";
        }

        public override double GetCost()
        {
            return coffee.GetCost() + 1.0;
        }
    }
}
