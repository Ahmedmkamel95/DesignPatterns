using DesignPatterns.Structural.Decorator.Interface;

namespace DesignPatterns.Structural.Decorator.Component
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return coffee.GetDescription() + ", Milk";
        }

        public override double GetCost()
        {
            return coffee.GetCost() + 2.0;
        }
    }
}
